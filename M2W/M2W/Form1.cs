using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;

namespace M2W
{
    public partial class Form1 : Form
    {
        // Declare as nullable since it is initialized later
        private CancellationTokenSource? cancellationTokenSource;

        public Form1()
        {
            InitializeComponent();
            AllowDrop = true;
            DragEnter += Form1_DragEnter;
            DragDrop += Form1_DragDrop;
            progressBar!.Visible = false;
            btnCancel!.Enabled = false;
        }

        private void btnBrowseInput_Click(object? sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog { Filter = "MP3 Files|*.mp3" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtInputPath!.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnBrowseOutput_Click(object? sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog { Filter = "WAV Files|*.wav" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtOutputPath!.Text = saveFileDialog.FileName;
                }
            }
        }

        private async void btnConvert_Click(object? sender, EventArgs e)
        {
            string inputPath = txtInputPath.Text;
            string outputPath = txtOutputPath.Text;

            if (string.IsNullOrEmpty(inputPath) || string.IsNullOrEmpty(outputPath))
            {
                MessageBox.Show("Please select input and output paths.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblStatus.Text = "Converting...";
            btnConvert.Enabled = false;

            cancellationTokenSource = new CancellationTokenSource();

            try
            {
                await Task.Run(() => ConvertMp3ToWav(inputPath, outputPath, cancellationTokenSource.Token));
                lblStatus.Text = "Completed";
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Error";
                MessageBox.Show($"Error: {ex.Message}", "Conversion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnConvert.Enabled = true;
            }
        }

        private void ConvertMp3ToWav(string mp3FilePath, string wavFilePath, CancellationToken cancellationToken)
        {
            LogMessage($"Starting conversion: {Path.GetFileName(mp3FilePath)} → {Path.GetFileName(wavFilePath)}");

            using var mp3Reader = new Mp3FileReader(mp3FilePath);
            using var pcmStream = WaveFormatConversionStream.CreatePcmStream(mp3Reader);
            using var waveFileWriter = new WaveFileWriter(wavFilePath, pcmStream.WaveFormat);

            Invoke(() =>
            {
                progressBar.Visible = true;
                progressBar.Value = 0;
                btnCancel.Enabled = true;
                lblStatus.Text = "Converting...";
            });

            byte[] buffer = new byte[16384]; // Larger buffer for better performance
            int bytesRead;
            long totalBytes = pcmStream.Length;
            long processedBytes = 0;

            while ((bytesRead = pcmStream.Read(buffer, 0, buffer.Length)) > 0)
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    Invoke(() =>
                    {
                        lblStatus.Text = "Cancelled";
                        LogMessage("Conversion cancelled.");
                        MessageBox.Show("Conversion cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    });
                    return;
                }

                waveFileWriter.Write(buffer, 0, bytesRead);
                processedBytes += bytesRead;

                int progress = (int)((processedBytes * 100) / totalBytes);
                Invoke(() => progressBar.Value = Math.Min(progress, 100));
            }

            Invoke(() =>
            {
                lblStatus.Text = "Completed";
                LogMessage("Conversion completed successfully.");
                progressBar.Visible = false;
                btnCancel.Enabled = false;
            });
        }

        private void btnCancel_Click(object? sender, EventArgs e)
        {
            cancellationTokenSource?.Cancel();
            LogMessage("Cancellation requested.");
        }

        private void LogMessage(string message)
        {
            if (rtbLog.InvokeRequired)
            {
                rtbLog.Invoke(new Action(() => LogMessage(message)));
            }
            else
            {
                string timestamp = DateTime.Now.ToString("HH:mm:ss");
                rtbLog.AppendText($"[{timestamp}] {message}\n");
                rtbLog.ScrollToCaret();
            }
        }

        private void Form1_DragEnter(object? sender, DragEventArgs e)
        {
            if (e.Data != null && e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void Form1_DragDrop(object? sender, DragEventArgs e)
        {
            if (e.Data == null) return; // Prevents null reference issues

            string[]? files = e.Data.GetData(DataFormats.FileDrop) as string[];
            if (files != null && files.Length > 0 && files[0].EndsWith(".mp3"))
            {
                txtInputPath!.Text = files[0];
            }
        }

    }
}
