using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocatingManager : MonoBehaviour
{
    public GameObject target;
    public GameObject joystick;
    public GameObject leftRotate;
    public GameObject rightRotate;
    public GameObject infoPanel;
    public GameObject block;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Set(GameObject a,Vector3 position, Vector3 scale)
    {
        target = a;
        a.transform.position = position;
        a.transform.localScale = scale;
        joystick.GetComponent<Joystick>().selectedFurniture = a.transform;
        leftRotate.GetComponent<LeftRotate>().target = a.transform;
        rightRotate.GetComponent<RightRotate>().target = a.transform;
        infoPanel.GetComponent<UpdateInfo>().target = a.transform;
        infoPanel.GetComponent<UpdateInfo>().Init();
    }

    public void ModifyInfo()
    {
        block.GetComponent<LocatedListBlock>().RealFurnituring(target.transform.position, target.transform.localScale);
    }
}
