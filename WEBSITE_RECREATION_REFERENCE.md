# Jelly Jump Arcade website reference (captured 2026-11-10)

The user supplied a SaveWeb2ZIP capture of their own published web recreation of Jelly Jump:
https://jelly-jump-arcade-rjl.eloquentcarp1.chatgpt.site/

The captured **game.js** is actual website gameplay code. This is a separate, modern, simplified recreation, **not the missing original 2015 Unity gameplay code**. Do not replace recovered Unity engine/scene assets with the website's approximations blindly.

## Visual features worth matching

- Image-backed splash/title screen with original-style logo and play button
- Five-node illustrated level map
- Layered parallax backgrounds (`w1_layer0`, `w1_layer1`, `w1_layer5`)
- Foreground with original-style terrain rendered as stage images
- Red jelly sprite with directional flip, in-air rotation, and landing squash/stretch
- Jump counter, level label, pause/retry, end/death overlays, star rewards

The current Unity repair restores the original 3D level scenes and world background scenes and has a temporary placeholder character/UI. Where possible, use original recovered Unity textures/meshes rather than rasterizing the stage.

## Published website physics (JavaScript, arbitrary 2D units)

- Horizontal jump launch: `vx = dir * 13.8`
- Vertical jump launch: `vy = 12.5`
- Gravity: `vy -= 24 * dt`
- On-ground horizontal drag: `vx *= exp(-3.7 * dt)`
- Camera follow smoothing: `viewX += (player.x - viewX) * (1-exp(-6*dt))`;
  `viewY += (player.y+0.7-viewY) * (1-exp(-2.4*dt))`
- Landing squash begins at `0.32`, decays `exp(-10*dt)`; jump stretch begins at `-0.12`
- Ground-only jump in browser recreation, direction chosen based on the tap's horizontal location.
- Camera uses 2D `zoom = min(W/33,H/22)`

Note: Unity project scene dimensions, physics timestep, colliders, and target mechanics differ; these numbers cannot be copied into Rigidbody settings without calibration against original gameplay videos.

## Original-site capture limitations

The capture included title/map art and `game.js`, but omitted 19 assets dynamically referenced at runtime:

- `media/l1.json` … `media/l5.json`, `media/l1.webp` … `media/l5.webp`
- `media/w1_layer0.webp`, `media/w1_layer1.webp`, `media/w1_layer5.webp`
- `media/character.webp`, `media/star_1.webp`
- `media/geleia_pulo.wav`, `media/geleia_chao_2_low.wav`, `media/teleport.wav`, `media/derrota_queda_2.wav`

The stage JSON carries `start`, `end`, `lines`, `hazards`, `left`, `top`, and `scale`, so without those files the five web levels cannot be reconstructed exactly from this ZIP. The user received a Mac recovery kit to try downloading these assets from their public website.

Action: Review website-derived aesthetics in tandem with original iOS gameplay recordings; preserve source Unity assets, prefer gameplay fidelity over superficial visual similarity.
