using System.IO;
using UnityEditor;

public class AssetBundleBuilder
{
    [MenuItem("Builder/Build AssetBundles")]
    private static void BuildAssetBundles()
    {
        if (!Directory.Exists(Data.OUTPUT_PATH))
        {
            Directory.CreateDirectory(Data.OUTPUT_PATH);
        }

        BuildPipeline.BuildAssetBundles(Data.OUTPUT_PATH, BuildAssetBundleOptions.None, EditorUserBuildSettings.activeBuildTarget);
    }
}
