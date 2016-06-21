using UnityEditor;

public class AutoBuild  {
	public static void BuildAndroid()
	{
		string[] levels = { "Assets/Scenes/GameScene.unity"};
		BuildPipeline.BuildPlayer(levels, "test2d01.apk", BuildTarget.Android, BuildOptions.None);
	}
}