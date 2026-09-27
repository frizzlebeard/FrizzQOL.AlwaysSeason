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

## Publishing

This folder is ready to push as its own public repository. Create an empty GitHub repo named `FrizzQOL.AlwaysSeason`. Do not add a README, license, or gitignore on GitHub. Those files are already here. Then run:

```
git remote add origin https://github.com/<you>/FrizzQOL.AlwaysSeason.git
git push -u origin main
```

Set `website_url` in `Package/manifest.json` to that repository before the Thunderstore upload.

## Thunderstore package

Zip these files from `Package` together with the Release dll:

- `manifest.json`
- `README.md`
- `CHANGELOG.md`
- `LICENSE`
- `icon.png`
- `FrizzQOL.AlwaysSeason.dll`
