using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class CategoryManage : MonoBehaviour
{
    private class Furniture
    {
        public string name;
        public int number;
        public int x,y,z;
    }

    public List<FurnitureData> furnitureData;
    public GameObject locatingUI;
    public GameObject prefab;
    public GameObject plusButton;
    public GameObject sampleCategory;
    public GameObject userCategory;
    public GameObject sampleContent;
    public GameObject userContent;
    public int initialSize = 10;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < furnitureData.Count; i++)
        {
            FurnitureBlock block = MakeBlock(i);

            block.transform.SetParent(sampleContent.transform);
            
        }
        userCategory.SetActive(false);
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TurnOffCategory()
    {
        plusButton.SetActive(true);
        gameObject.SetActive(false);
    }

    public void SetToSample()
    {
        sampleCategory.SetActive(true);
        userCategory.SetActive(false);
    }
    public void SetToUser()
    {
        userCategory.SetActive(true);
        sampleCategory.SetActive(false);
    }

    public void Selected(GameObject furniture)
    {
        locatingUI.SetActive(true);
        locatingUI.GetComponent<LocatingManager>().Set(furniture);
        gameObject.SetActive(false);
    }

    private FurnitureBlock MakeBlock(int num)
    {
        var newFurnifure = Instantiate(prefab).GetComponent<FurnitureBlock>();
        newFurnifure.FurnitureData = furnitureData[num];
        newFurnifure.Setting();

        return newFurnifure;
    }
}