# Jelly Jump recovery — incomplete / untested

This branch contains reconstructed code for an early-2010s Unity 4.2.1f4 iOS title. **It is not a working game release.** The original ARMv7 IPA cannot simply be made 64-bit. Many Mono assembly methods decompiled to empty stubs, so this branch contains manually written approximations rather than recovered original implementations.

## Work completed
- Removed one duplicate `AssemblyInfo.cs` and matching `.meta`.
- Replaced invalid ILSpy `/*Error*/` expressions with placeholder `return default;` statements, for compilation triage.
- Ported the legacy UnityScript rigidbody drag helper.
- Added preliminary C# replacements for player touch jumping, game/session control, player progress saves, HUD counters, level lookups and camera tracking.
- Added 26 recovered level scenes, plus `GamePlay.unity`, to Build Settings.
- Added static source checks and an editor command to export an iOS Xcode project.

## Known blockers
- Several decompiled components still have empty method bodies. Compile-safe placeholders do **not** restore gameplay.
- The original `Assets/Scenes/Menu.unity` is an **empty file**. The current build intentionally starts with `GamePlay.unity`.
- The GamePlay scene does not appear to contain a serialized `CharacterControl` instance; the temporary fallback ball is **not** the original jelly character.
- Many scene references, scripts, materials, prefabs, plugins and animation behaviors need testing/repair under Unity 2022.3.62f3.
- The restored code is based on Unity 2022 APIs, but there has been **no Unity Editor compile, playtest or iOS build verification**.
- The Xcode export command is **not** an IPA packager. Creating an unsigned arm64 IPA requires a working iOS Xcode build on macOS and packaging the app; signing is a separate process.

## Testing
The GitHub Action only checks for decompiler-error tokens, basic scene availability and duplicate assembly info. It does **not** run Unity.

On a Mac with Unity 2022.3.62f3 and iOS Build Support, open the project, let Unity reimport, resolve Console errors, and use **Jelly Jump > Export iOS Xcode Project**. If compilation fails, inspect `Editor.log` for the first error. Do not mistake a successful static check for a playable IPA.

## Original project
The `main` branch remains unchanged. Repairs are isolated to `jelly-jump-repair`.
