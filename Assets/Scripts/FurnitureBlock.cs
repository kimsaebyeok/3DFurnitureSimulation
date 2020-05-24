using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FurnitureBlock : MonoBehaviour
{
    public GameObject locatingUI;
    public GameObject categoryManage;
    [SerializeField]
    private FurnitureData furnitureData;
    public FurnitureData FurnitureData{ set { furnitureData = value; } }
    public GameObject locatedListBlock;
    public GameObject locatedList;
    public GameObject listContent;
   
    // Start is called before the first frame update

    public void OnClick()
    {
        GameObject a = Instantiate(furnitureData.FurniturePrefab);

        GameObject block = Instantiate(locatedListBlock);
        block.GetComponent<LocatedListBlock>().target = a;
        block.GetComponent<LocatedListBlock>().Setting(furnitureData);
        locatingUI.GetComponent<LocatingManager>().block = block;

        block.transform.SetParent(listContent.transform);

        MeshFilter[] meshFilters = a.GetComponentsInChildren<MeshFilter>();
        
        CombineInstance[] combine = new CombineInstance[meshFilters.Length];
        Material mat = a.GetComponent<MeshRenderer>().material;
        int i = 0;
        while (i < meshFilters.Length)
        {
           combine[i].mesh = meshFilters[i].sharedMesh;
            combine[i].transform = meshFilters[i].transform.localToWorldMatrix;
           meshFilters[i].gameObject.SetActive(false);

            i++;
        }
        a.transform.eulerAngles =new  Vector3(-90, 0, 0);
        a.transform.GetComponent<MeshFilter>().mesh = new Mesh();
        a.transform.GetComponent<MeshFilter>().mesh.CombineMeshes(combine);
        a.GetComponent<MeshCollider>().sharedMesh = a.transform.GetComponent<MeshFilter>().mesh;
        a.transform.gameObject.SetActive(true);
        a.GetComponent<MeshRenderer>().material = mat;
        
        
        categoryManage.GetComponent<CategoryManage>().Selected(a);
    }

    public void Setting()
    {
        gameObject.transform.Find("Text").GetComponent<Text>().text = furnitureData.name;
    }
}
