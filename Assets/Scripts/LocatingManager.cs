using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocatingManager : MonoBehaviour
{
    private GameObject target;
    public GameObject joystick;
    public GameObject leftRotate;
    public GameObject rightRotate;
    public GameObject infoPanel;
    public GameObject cancelButton;
    public GameObject confirmButton;
    public Transform spwanPoint;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Set(GameObject a)
    {
        target = a;
        a.transform.position = spwanPoint.position;
        joystick.GetComponent<Joystick>().selectedFurniture = a.transform;
        leftRotate.GetComponent<LeftRotate>().target = a.transform;
        rightRotate.GetComponent<RightRotate>().target = a.transform;
        infoPanel.GetComponent<UpdateInfo>().target = a.transform;
        infoPanel.GetComponent<UpdateInfo>().Init();
    }
}
