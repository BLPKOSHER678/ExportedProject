#!/usr/bin/env python3
"""Static preflight only; this is NOT a Unity compile or iPhone build."""
from pathlib import Path
import re
import sys

root = Path(__file__).resolve().parents[2]
scripts = list((root / "Assets" / "Scripts").rglob("*.cs"))
issues = []
if not scripts:
    issues.append("No C# scripts")
for file in scripts:
    if "/*Error:" in file.read_text(encoding="utf-8", errors="replace"):
        issues.append("Decompiler error remains: " + str(file.relative_to(root)))
settings = root / "ProjectSettings" / "EditorBuildSettings.asset"
text = settings.read_text(encoding="utf-8")
scenes = re.findall(r"^    path: (.+\.unity)$", text, re.MULTILINE)
if len(scenes) < 2 or scenes[0] != "Assets/Scenes/GamePlay.unity":
    issues.append("First build scene must be GamePlay, followed by at least one level")
for scene in scenes:
    if not (root / scene).is_file():
        issues.append("Missing build scene: " + scene)
info = list((root / "Assets" / "Scripts").rglob("AssemblyInfo.cs"))
if len(info) > 1:
    issues.append("Duplicate assembly-info files: " + str(info))
print(f"Checked {len(scripts)} scripts and {len(scenes)} build scenes.")
print("The original stripped method implementations remain partially reconstructed.")
print("This test cannot verify Unity compilation, gameplay fidelity, Xcode export, or an IPA.")
for issue in issues:
    print("ERROR:", issue)
sys.exit(1 if issues else 0)
