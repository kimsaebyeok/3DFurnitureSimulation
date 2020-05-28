using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingRoom : MonoBehaviour
{
    GameObject informationObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        informationObject = GameObject.FindGameObjectWithTag("Information Object");
        if (informationObject == null)
        {
            return;
        }
        if(informationObject.name == "RoomInformation")
        {
            string[] dataLine = Parse(informationObject.GetComponent<RoomInfo>().);
        }
    }
