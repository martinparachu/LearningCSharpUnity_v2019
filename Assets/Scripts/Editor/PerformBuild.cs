using UnityEditor;
using UnityEngine;

class BuildSrcipt
{
    static string[] scenes = { "Assets/Scenes/CSharpScene.unity" };
    static string name = "HelloWorld";


    static void BuildLinux()
    {
        BuildPipeline.BuildPlayer(scenes, "./" + name + "_Linux/" + name, BuildTarget.StandaloneLinux64, BuildOptions.None);
    }

    static void BuildMac()
    {
        BuildPipeline.BuildPlayer(scenes, "./" + name + "_Mac/" + name, BuildTarget.StandaloneOSX, BuildOptions.None);
    }
}

