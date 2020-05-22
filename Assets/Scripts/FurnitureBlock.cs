using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FurnitureBlock : MonoBehaviour
{
    public GameObject selectedUI;
    public GameObject categoryManage;
    [SerializeField]
    private FurnitureData furnitureData;
    public FurnitureData FurnitureData{ set { furnitureData = value; } }
    // Start is called before the first frame update

    public void OnClick()
    {
        GameObject a = Instantiate(furnitureData.FurniturePrefab);

        MeshFilter[] meshFilters = a.GetComponentsInChildren<MeshFilter>();
        CombineInstance[] combine = new CombineInstance[meshFilters.Length];
        int i = 0;
        while (i < meshFilters.Length)
        {
            combine[i].mesh = meshFilters[i].sharedMesh;
            combine[i].transform = meshFilters[i].transform.localToWorldMatrix;
            //meshFilters[i].gameObject.SetActive(false);

            i++;
        }
        a.transform.GetComponent<MeshFilter>().mesh = new Mesh();
        a.transform.GetComponent<MeshFilter>().mesh.CombineMeshes(combine);
        a.transform.gameObject.SetActive(true);
        
        categoryManage.GetComponent<CategoryManage>().Selected(a);
    }

    public void Setting()
    {
        gameObject.transform.Find("Text").GetComponent<Text>().text = furnitureData.name;
    }
}
