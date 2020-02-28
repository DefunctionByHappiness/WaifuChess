using UnityEditor;

class BB8ild
{
	[MenuItem("Build/Build WebGL")]
	static void PerformBuild()
	{
		var sceneSettings = EditorBuildSettings.scenes;
		string[] scenePaths = new string[sceneSettings.Length];

		for (int i = 0; i < scenePaths.Length; ++i)
		{
			scenePaths[i] = sceneSettings[i].path;
		}
		BuildPipeline.BuildPlayer(scenePaths, "build/web-gl", BuildTarget.WebGL, BuildOptions.None);
	}
}