using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;

public class ObjectData
{
    public int ROOMID;
    public int OBJECTID;
    public float objectx;
    public float objecty;
    public float objectz;
    public int objectkey;
    public int objectsizex;
    public int objectsizey;
    public int objectsizez;
    public float objectrotation;
}

public class LoadingRoom : MonoBehaviour
{
    public GameObject floor;
    public GameObject list;
    public GameObject category;
    GameObject informationObject;
    GameObject userRoomInfo;
    GameObject createdRoomInfo;
    GameObject roomInfo;
    RoomInfo ri;
    UserRoomInfo ur;
    CreatedRoomInfo cr;
    public  bool isUR = true;
    public int x, y, z;
    public int roomId;
    public string roomName;

    WWW www;
    public bool isDownloaded = false;
    JsonData itemdata;

    // Start is called before the first frame update
    void Start()
    {
        userRoomInfo = GameObject.Find("UserRoomInformation");
        roomInfo = GameObject.Find("RoomInformation");
        createdRoomInfo = GameObject.Find("CreatedRoomInformation");
        if (roomInfo != null)
        {
            ri = roomInfo.GetComponent<RoomInfo>();
            x = ri.x;
            y = ri.y;
            z = ri.z;
            roomId = ri.roomId;
            Debug.Log(roomId);
        }
        /*else if (userRoomInfo != null)
        {
            ur = userRoomInfo.GetComponent<UserRoomInfo>();
            x = ur.x;
            y = ur.y;
            z = ur.z;
            roomId = ur.roomId;
            roomName = ur.roomName;
        }*/
        else if (createdRoomInfo != null)
        {
            isUR = false;
            createdRoomInfo = GameObject.Find("CreatedRoomInformation");
            cr = createdRoomInfo.GetComponent<CreatedRoomInfo>();
            x = cr.x;
            y = cr.y;
            z = cr.z;
            roomId = cr.roomId;
            Debug.Log(roomId);
        }        

        StartCoroutine(Send());



        FurnitureBlock[] blocks = list.GetComponentsInChildren<FurnitureBlock>();

        for (int i = 0; i < itemdata.Count; i++)
        {
            for (int j = 0; j < blocks.Length; j++)
            {
                if (int.Parse(blocks[j].furnitureData.FurnitureNumber) == int.Parse(itemdata[i]["objectkey"].ToString()))
                {
                    blocks[j].LoadFurniture(new Vector3(int.Parse(itemdata[i]["objectx"].ToString()), int.Parse(itemdata[i]["objecty"].ToString()), int.Parse(itemdata[i]["objectz"].ToString()))
                                                                ,new Vector3(0, int.Parse(itemdata[i]["objectrotation"].ToString()), 0));
                }
            }
        }
    }

    IEnumerator Send()
    {
        string ip = "10.14.4.49";
        isDownloaded = false;
        www = new WWW("http://" + ip + "/~kim/searchobject.php?ROOMID=" + roomId);
        yield return www;
        if (www.isDone) isDownloaded = true;

        Debug.Log(www.text);

        itemdata = JsonMapper.ToObject(www.text);

        for (int i = 0; i < itemdata.Count; i++)
        {
            Debug.Log(itemdata[i]["objectkey"].ToString());
            Debug.Log(itemdata[i]["ROOMID"].ToString());
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        /*informationObject = GameObject.FindGameObjectWithTag("Information Object");
        if (informationObject == null)
        {
            return;
        }
        if(informationObject.name == "RoomInformation")
        {
            string[] dataLine = Parse(informationObject.GetComponent<RoomInfo>().);
        }*/
    }
}
