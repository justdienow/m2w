# M2W - MP3 to WAV Converter

A lightweight Windows desktop application for converting MP3 files to WAV format. Built with C# and Windows Forms on .NET 8.

## Features

- Convert MP3 files to uncompressed PCM WAV
- Browse for input/output files via file dialogs
- Drag and drop MP3 files directly onto the window
- Real-time progress bar during conversion
- Cancel an in-progress conversion at any time
- Timestamped activity log
- Splash screen on startup

## Requirements

- Windows 10 or later
- [.NET 8.0 Desktop Runtime](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) (for running without Visual Studio)

No additional audio codecs required — NAudio handles MP3 decoding natively.

## Usage

1. Launch `M2W.exe`
2. Click **Select** next to *Source file* and choose an MP3, or drag and drop an MP3 file onto the window
3. Click **Select** next to *Output file* and choose where to save the WAV
4. Click **Convert**
5. Monitor progress via the progress bar and log panel
6. Optionally click **Cancel** to stop an in-progress conversion

---

## Dev Setup

### Prerequisites

- [Visual Studio 2022](https://visualstudio.microsoft.com/) with the **.NET desktop development** workload, or
- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) (for CLI builds)

### Clone and open

```bash
git clone <repo-url>
cd m2w
```

Open `M2W/M2W.sln` in Visual Studio, or use the CLI:

```bash
dotnet restore M2W/M2W.sln
dotnet build M2W/M2W.sln
```

### Run

```bash
dotnet run --project M2W/M2W/M2W.csproj
```

Or press **F5** in Visual Studio.

### Dependencies

Dependencies are managed via NuGet and restored automatically on build:

| Package | Version | Purpose |
|---------|---------|---------|
| [NAudio](https://github.com/naudio/NAudio) | 2.2.1 | MP3 decoding and WAV writing |

---

## Release

### Build a Release binary

```bash
dotnet publish M2W/M2W/M2W.csproj \
  -c Release \
  -r win-x64 \
  --self-contained true \
  -p:PublishSingleFile=true \
  -o ./publish
```

This produces a single `M2W.exe` in `./publish` that includes the .NET runtime — no installation required on the target machine.

For a framework-dependent build (smaller binary, requires .NET 8 runtime on the target):

```bash
dotnet publish M2W/M2W/M2W.csproj \
  -c Release \
  -r win-x64 \
  --self-contained false \
  -p:PublishSingleFile=true \
  -o ./publish
```

### Versioning

The splash screen reads the version from the assembly at runtime. Set the version before publishing by adding it to `M2W.csproj`:

```xml
<PropertyGroup>
  <Version>1.0.0</Version>
</PropertyGroup>
```

---

## Project Structure

```
m2w/
├── README.md
├── CLAUDE.md               AI assistant instructions
├── .gitignore
└── M2W/
    ├── M2W.sln
    └── M2W/
        ├── M2W.csproj
        ├── Program.cs          Entry point
        ├── Form1.cs            Main window and conversion logic
        ├── SplashScreen.cs     Startup splash screen
        ├── m2w.ico
        ├── Properties/
        │   └── Resources.resx  Embedded resources (splash image)
        └── Resources/
            └── M2W_Splash.png
```
