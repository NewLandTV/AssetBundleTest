using System.IO;
using UnityEngine;

public class Data
{
    public const string OUTPUT_PATH = "E:\\Temp\\MyAssetBundles";
    public const string BUNDLE_NAME = "test_asset_bundle";
    public const string ASSET_NAME = "Floor";
}

public class Main : MonoBehaviour
{
    [SerializeField]
    private GameObject originFloorObject;

    public void OnLoadButtonClick()
    {
        AssetBundle localAssetBundle = AssetBundle.LoadFromFile(Path.Combine(Data.OUTPUT_PATH, Data.BUNDLE_NAME));

        if (localAssetBundle == null)
        {
            return;
        }

        Destroy(originFloorObject);

        GameObject floor = localAssetBundle.LoadAsset<GameObject>(Data.ASSET_NAME);

        GameObject floorInstance = Instantiate(floor);

        floorInstance.GetComponent<MeshRenderer>().material = localAssetBundle.LoadAsset<Material>(Data.ASSET_NAME);

        localAssetBundle.Unload(false);
    }
}
