# dreamcube.itp.pitch.example.unity

# DreamCube Train To Win Project

This program known as the _Pitch_ is the main software component for the _DreamCube's_ interactive virtual reality room. The main attraction is an arcade-style ball game using a physical ball tracked in three-dimensions. It features surround video and audio cut scenes to create guided stories through championship seasons.

_For additional details about this project as a whole, you should refer to the [Project Handbook](https://github.com/local-projects/manutd.project-handbook)_


<!-- TOC -->

## Table of Contents

- [Project Details](#project-details)
- [Installation](#installation)
- [Usage](#usage)
- [Troubleshooting](#troubleshooting)
- [Roadmap](#roadmap)
- [License](#license)
- [Notes](#notes)

---

<!-- Project Details -->

## Project Details

### Resources

- [Project Handbook](https://github.com/local-projects/manutd.project-handbook)
- [CI Pipeline](http://build.localprojects.com/project/ManU)

### Dependencies & Frameworks

The following submodules are used in compilation.
- Addressables
- JetBrains Rider Editor
- ProBuilder
- Test Framework
- TextMeshPro
- Timeline
- Unity Collaborate
- Unity Recorder
- Unity UI
- Universal RP
- Shader Graph
- Visual Effect Graph
- Visual Studio Code Editor
- Visual Studio Editor
- Serilog Sink for Unity 3D

The following applications are used in development.

- [Unity 2020.3.6](https://download.unity3d.com/download_unity)
- [Visual Studio 2019](https://visualstudio.microsoft.com/) + [ReSharper](https://www.jetbrains.com/resharper/) or [Rider](https://www.jetbrains.com/rider/)
- [Node.js](https://nodejs.org/dist/v12.18.4/node-v12.18.4-x64.msi) for [OpenUPM](https://openupm.com/)

The following libraries and their dependencies are included in the `Plugins` folder.

- [Newtonsoft.Json 12.0.3](https://www.nuget.org/packages/Newtonsoft.Json/)
- [Serilog 2.9.0](https://www.nuget.org/packages/serilog/)
- [Serilog.Sinks.File 5.0.0-dev-00880](https://www.nuget.org/packages/Serilog.Sinks.File/5.0.0-dev-00880)
- [Google.Protobuf 3.11.4](https://www.nuget.org/packages/Google.Protobuf)
- [DoTween](https://github.com/Demigiant/dotween)
- [Odin - Serializer](https://github.com/TeamSirenix/odin-serializer)
- [Unity UI Extensions](https://bitbucket.org/UnityUIExtensions)
- [FMOD for Unity](https://assetstore.unity.com/packages/tools/audio/fmod-for-unity-161631?aid=1100l355n&gclid=CjwKCAiAzNj9BRBDEiwAPsL0d_vc0xfTtM6wHIY1iyJHxMc5aTb8ya7XVmjeK4mfO_wSZDS4KieusBoCAagQAvD_BwE&pubref=UnityAssets%2ADyn09%2A1723478829%2A67594162255%2A336275757769%2Ag%2A%2A%2Ab%2Ac%2Agclid%3DCjwKCAiAzNj9BRBDEiwAPsL0d_vc0xfTtM6wHIY1iyJHxMc5aTb8ya7XVmjeK4mfO_wSZDS4KieusBoCAagQAvD_BwE&utm_source=aff)

The Following Packages are used
- 

#### Setting up Serilog

OpenUPM is used for [Serilog.Sinks.Unity3D](https://openupm.com/packages/com.serilog.sinks.unity3d/)
cd into your project and install then unity sink
`openupm add com.serilog.sinks.unity3d`

See the [manifest file](https://github.com/local-projects/dreamcube.pitch-app-shell.unity/blob/main/Dreamcube.pitch-app-shell/Packages/manifest.json) for additional packages installed through Unity's package manager.

<!-- Installation -->

## Installation

1. Clone the repo:
```
git clone --recurse-submodules https://github.com/local-projects/dreamcube.pitch-app-core.unity
```

2. Set the configuration file:

An external settings file is required. It's located at `StreamingAssets\general_config.json`.
If the file does not exist it will be created using the default values at first run.

`SignalRUri` - URI of Game Center SignalR server <br />
`DreamCube` - Name of assigned DreamCube <br />
`Debug` - Whether the app is in debug mode <br />
`RTLSLocalIP` - IP of the computer's NIC running this software to which you want to bind RTLS <br />
`RTLSRemoteIP` - IP of the RTLS Server <br />
`RTLSPort` - Port of the RTLS <br />
`LogDirectory` - Serilog file directory <br />
`LogLevel` - Serilog minimum log level <br />
`LogName` - Serilog base file name and extension <br />
`UseASIO`- Audio output to the DSP <br />
`ASIODriverIndex`- Audio output Index <br />
`AsioAutoDetectName` - Audio output name <br />
`DSPBufferLength` - DSP Buffer length <br />
`DSPBufferCount` - DSP Buffer Count <br />


```
{
  "DreamCube": "1",
  "Debug": false,
  "UseRTLS": true,
  "RTLSLocalIP": "192.168.x.x",
  "RTLSRemoteIP": "192.168.x.x",
  "RTLSPort": 8282,
  "LogDirectory": "C:\\GameBay\\Logs",
  "LogLevel": "debug",
  "LogName": "pitch-.txt",
  "UseASIO": true,
  "ASIODriverIndex" : 0,
  "AsioAutoDetectName" : "RedNet PCIe",
  "DSPBufferLength" :1024,
  "DSPBufferCount" :8,
}
```


3. Open the project with [Unity Hub](https://unity3d.com/get-unity/download). It will prompt you to download the correct version of the Unity editor.

4. Open the `App\_Scenes\_Main` scene.

5. Open the `Addressables` tab [Window-> Asset Management -> Addressables].

6. Click `Build -> New Build -> Default Build Script`.

7. Build the project according to [Unity's documentation](https://docs.unity3d.com/Manual/PublishingBuilds.html).


<!-- USAGE -->

## Usage




<!-- TROUBLESHOOTING -->

## Troubleshooting

_The program does not show on the correct displays._<br />
In the Windows or GPU display manager, the displays should be tiled left to right with indices 1-4. Display 1 should set to the `primary screen`.

_For more detail, you should refer to the **[Project Handbook](https://github.com/local-projects/manutd.project-handbook)**_

<!-- ROADMAP -->

## Roadmap


<!-- LICENSE -->

## License

© Copyright 2020 Local Projects, Inc., All Rights Reserved.
_See `LICENSE` for more information._

---

<!-- NOTES -->

## Notes



