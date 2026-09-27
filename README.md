# FrizzQOL Always Season

Seasonal craft recipes and build pieces stay unlocked all year. Valheim normally locks them to the real-world calendar, and only one holiday is active at a time.

There is no config file.

## Multiplayer

Install this on every player. A dedicated server does not need it.

## Install

Install with r2modman or the Thunderstore Mod Manager.

To install by hand, copy `FrizzQOL.AlwaysSeason.dll` into `BepInEx/plugins`.

## Requirements

- Valheim
- [BepInExPack for Valheim](https://thunderstore.io/c/valheim/p/denikson/BepInExPack_Valheim/)

## License

[MIT](LICENSE). You can use, copy, change, and share this mod. Keep the copyright notice with any copy.

## Building

1. Copy `Environment.props.example` to `Environment.props`.
2. Set your Valheim and BepInEx folders in that file.
3. From this folder, run:

```
dotnet build AlwaysSeason.sln -c Release
```

The plugin file is `FrizzQOL.AlwaysSeason.dll`, under the project `bin\Release\net48` folder.

`Environment.props` stays on your machine. It is listed in `.gitignore`.

## Source

https://github.com/frizzlebeard/FrizzQOL.AlwaysSeason
