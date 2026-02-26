# M2W - MP3 to WAV Converter

## Project Overview
A Windows desktop application that converts MP3 files to WAV format. Built with C# Windows Forms on .NET 8.0, using NAudio for audio processing.

## Tech Stack
- **Language:** C# (.NET 8.0, `net8.0-windows`)
- **UI Framework:** Windows Forms (WinForms)
- **Audio Library:** NAudio 2.2.1
- **IDE:** Visual Studio 2022
- **Solution:** `M2W/M2W.sln`
- **Project:** `M2W/M2W/M2W.csproj`

## Project Structure
```
m2w/
├── CLAUDE.md
├── README.md
├── .gitignore
└── M2W/
    ├── M2W.sln
    └── M2W/
        ├── M2W.csproj
        ├── Program.cs              Entry point: shows splash, then launches Form1
        ├── Form1.cs                Main window + conversion logic
        ├── Form1.Designer.cs       Auto-generated designer code — do not edit manually
        ├── SplashScreen.cs         Fade-out splash screen (2s display + fade animation)
        ├── SplashScreen.Designer.cs
        ├── m2w.ico
        ├── Properties/
        └── Resources/              Contains M2W_Splash image resource
```

## Key Components

### Form1 (Main Window)
- **Controls:** `txtInputPath`, `txtOutputPath`, `btnBrowseInput`, `btnBrowseOutput`, `btnConvert`, `btnCancel`, `progressBar`, `lblStatus`, `rtbLog`
- **Conversion pipeline:** `Mp3FileReader` → `WaveFormatConversionStream` → `WaveFileWriter`
- Conversion runs async via `Task.Run` with `CancellationToken` support
- Progress tracked by bytes processed vs total stream length
- Drag & drop MP3 files directly onto the form

### SplashScreen
- Borderless form, centered, topmost
- Displays for 2 seconds then fades out (opacity steps of 0.05 every 50ms)
- Shows app name, version (read from assembly), and status label

## Build & Run
```bash
# Build
dotnet build M2W/M2W.sln

# Run (requires Windows)
dotnet run --project M2W/M2W/M2W.csproj
```

## Coding Conventions
- Nullable reference types enabled — use `?` annotations and null checks
- UI updates from background threads must use `Invoke()`
- Designer files (`*.Designer.cs`) are auto-generated — never edit them manually
- Keep conversion logic in `Form1.cs`; do not split into separate service classes unless complexity justifies it
- Log messages via `LogMessage()` with `[HH:mm:ss]` timestamps

## Important Notes
- Target platform is Windows only (`net8.0-windows`, WinForms)
- NAudio's `Mp3FileReader` and `WaveFormatConversionStream` handle all codec work — no external codec installation needed
- The splash image (`M2W_Splash`) is an embedded resource in `Properties/Resources.resx`
- App icon is `m2w.ico`, referenced in both the `.csproj` and as a form icon resource
