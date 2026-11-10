using System;
using System.Linq;
using UnityEditor;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;
using UnityEngine;

/// <summary>Exports a 64-bit IL2CPP iOS Xcode project; this does not produce an IPA.</summary>
public static class JellyJumpIOSBuild
{
    [MenuItem("Jelly Jump/Export iOS Xcode Project")]
    public static void ExportIOS()
    {
        string[] scenes = EditorBuildSettings.scenes
            .Where(scene => scene.enabled && System.IO.File.Exists(scene.path))
            .Select(scene => scene.path).ToArray();
        if (scenes.Length < 2 || !scenes[0].EndsWith("GamePlay.unity"))
            throw new InvalidOperationException("Configure GamePlay as the first scene and enable at least one recovered level.");

        PlayerSettings.SetScriptingBackend(NamedBuildTarget.iOS, ScriptingImplementation.IL2CPP);
        PlayerSettings.SetApplicationIdentifier(NamedBuildTarget.iOS, "com.fungames.jellyjumpfree");
        PlayerSettings.iOS.targetOSVersionString = "12.0";
        if (!EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTargetGroup.iOS, BuildTarget.iOS))
            throw new InvalidOperationException("Install Unity iOS Build Support for this editor.");

        BuildPlayerOptions options = new BuildPlayerOptions {
            scenes = scenes,
            target = BuildTarget.iOS,
            locationPathName = "Builds/iOS-Xcode",
            options = BuildOptions.None
        };
        BuildReport report = BuildPipeline.BuildPlayer(options);
        if (report.summary.result != BuildResult.Succeeded)
            throw new Exception("iOS export failed. Inspect the Unity Console and Editor.log.");

        Debug.Log("Jelly Jump: Xcode project exported into Builds/iOS-Xcode. This is not a signed or unsigned IPA.");
    }
}
