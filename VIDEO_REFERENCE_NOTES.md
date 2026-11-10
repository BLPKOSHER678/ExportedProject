# Original Jelly Jump gameplay observations (recovery reference)

Source videos supplied by the project owner on 2026-11-10:
- `AppleAppVideo — Jelly Jump Level 1-4 ios iphone gameplay(2).mp4` (720×480, ~201 sec).
- `YTDown.com_YouTube_Media_eTe2JUlHWCE_Jelly-Jump-level-5-10-ios-iphone-gameplay_001_480p(2).mp4` (720×480, ~230 sec).
- `AppleAppVideo — Jelly Jump level 11-15 ios iphone gameplay(1).mp4` (720×480, ~244 sec).

## Observed behavior
- The game uses landscape framing with a side-on 2.5D play area, painted sky, distant mountain/planet background, textured grass/dirt and metal ramps.
- In level 1, around 17–21 seconds, the red one-eyed jelly is stationary on its starting pad with jump count **0**. At ~22 sec the jump counter becomes **1** and the jelly travels right. The character **does not automatically move forward while waiting**.
- The jelly is a short, rounded, red blob when grounded. In the air it stretches to a narrow elongated shape, then becomes squat on landing (e.g. ~22–27 sec of the first video).
- The jump counter at top left increases with successful jumps; the level number and a restart icon are displayed top right.
- The camera travels horizontally with the jelly, showing upcoming terrain while preserving broad views of the sky and mountain background. It is not a top-down platformer.
- Some surfaces are angled, platforms have edges/gaps, and the jelly can pause on a platform before the next tap (level 2, ~48–50 sec).
- The levels include bouncing/tilting metal platforms, swinging arms, spiked enemies, narrow vertical corridors, and wall traversal. Level 4 (~108–120 sec) and level 11 (~132–156 sec in the corresponding video) show significant vertical routing.
- The completion scene displays 1–3 star awards and jump thresholds; world map selection is a winding numbered route.
- Later levels (11–15) add red/brown wall layouts, more hazards and lifts. Level 15 appears in a warm desert palette.

## Code changes informed by observations
- `CharacterControl.cs`: no constant horizontal run velocity. A jump adds horizontal and vertical velocity; stopping on ground uses friction. Press-and-hold temporarily supports lift; wall contact permits another jump. All forces and timings are *initial estimates*, not measured original values.
- `GameControl.cs`: replace visually unrelated grey sphere fallback with a new separate red jelly visual.
- `RecoveredJellyVisual.cs`: creates a red one-eyed placeholder with basic squash/stretch animation. **Original model and animation were not recovered**.
- `PolygonMesh.cs` and `Mesh27Slice.cs` (earlier commits): reconstruct missing visual surfaces from preserved shape information.

## Still NOT restored or validated
- Original jump velocities, exact landing/friction and wall mechanics (require Unity playtest and more comparison).
- Original one-eyed jelly 3D mesh, facial animation, material/shader look.
- Original level mesh-generation algorithms, all interactive platforms, hazards, enemies, world map, HUD and completion flows.
- Texture/material compatibility with Unity 2022; magenta objects in a user's Unity screen recording likely indicate missing/unsupported shaders.
- Working 64-bit unsigned IPA or fully working Unity player.

Static GitHub source checks are **not** Unity editor compile tests or gameplay checks.

**Do not present this branch as an exact recreation of the supplied footage.**
