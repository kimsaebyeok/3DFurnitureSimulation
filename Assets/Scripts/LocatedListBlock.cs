using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LocatedListBlock : MonoBehaviour
{
    public GameObject locatingUI;
    public GameObject target;
    public GameObject listUI;
    public GameObject delete;
    public GameObject confirm;
    private Vector3 position;
    public Vector3 Position { get { return position; } }
    private Vector3 scale;
    public Vector3 Scale { get { return scale; } }
    private FurnitureData info;
    public FurnitureData Info { get { return info; } }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Setting(FurnitureData data)
    {
        info = data;
        gameObject.transform.Find("Text").GetComponent<Text>().text = info.FurnitureName;
    }

    public void OnClick()
    {
        locatingUI.SetActive(true);
        locatingUI.GetComponent<LocatingManager>().Set(target, position, scale);
        locatingUI.GetComponent<LocatingManager>().block = gameObject;
        locatingUI.GetComponent<LocatingManager>().target = target;
        delete.SetActive(true);
        delete.GetComponent<DeleteItem>().block = gameObject;
        listUI.SetActive(false);
    }

    public void Delete()
    {
        Destroy(target);
        Destroy(gameObject);
    }

    public void RealFurnituring(Vector3 positionData, Vector3 scaleData)
    {
        position = positionData;
        scale = scaleData;
    }
}
