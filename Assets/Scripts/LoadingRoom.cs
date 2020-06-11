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
    public GameObject plusImage;
    public GameObject listUI;
    public GameObject locatingUI;
    public GameObject saveButton;
    public GameObject confirmButton;
    public GameObject categoryManage;
    GameObject userRoomInfo;
    GameObject createdRoomInfo;
    GameObject roomInfo;
    RoomInfo ri;
    UserRoomInfo ur;
    CreatedRoomInfo cr;
    public bool isUR = true;
    public string addressDoSi;
    public string address;
    public int x, y, z;
    public int roomId;
    public string roomName;

    private GameObject target;
    private bool isLoaded = false;

    WWW www;
    public bool isDownloaded = false;
    JsonData itemdata = null;

    // Start is called before the first frame update
    public void Start()
    {
        //if (!isLoaded)
        {
            Debug.Log("Update");
            userRoomInfo = GameObject.Find("UserRoomInformation");
            roomInfo = GameObject.Find("RoomInformation");
            createdRoomInfo = GameObject.Find("CreatedRoomInformation");
            if (roomInfo != null)
            {
                ri = roomInfo.GetComponent<RoomInfo>();
                x = ri.x;
                y = ri.y;
                z = ri.z;
                //address = ri.address;
                //addressDoSi = ri.addressDoSi;
                roomId = ri.roomId;
                Debug.Log("roomid");
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
                isLoaded = true;
                return;

            }

            while (itemdata== null)
            {
                StartCoroutine(Send());
                if(itemdata != null)
                {
                    break;
                }

            }

            Debug.Log(itemdata.Count + "ㅎㅇ");


            FurnitureBlock[] blocks = list.GetComponentsInChildren<FurnitureBlock>();
            Debug.Log(itemdata.Count);
            for (int i = 0; i < itemdata.Count; i++)
            {
                Debug.Log(itemdata.Count);
                for (int j = 0; j < blocks.Length; j++)
                {
                    Debug.Log(blocks.Length);
                    if (int.Parse(blocks[j].furnitureData.FurnitureNumber) == int.Parse(itemdata[i]["objectkey"].ToString()))
                    {

                        target = blocks[j].LoadFurniture(new Vector3(int.Parse(itemdata[i]["objectx"].ToString()), int.Parse(itemdata[i]["objecty"].ToString()), int.Parse(itemdata[i]["objectz"].ToString())),
                            new Vector3(-90, float.Parse(itemdata[i]["objectrotation"].ToString()), target.transform.rotation.z),
                            new Vector3(int.Parse(itemdata[i]["objectsizex"].ToString()), int.Parse(itemdata[i]["objecty"].ToString()), int.Parse(itemdata[i]["objectz"].ToString())));
                    }
                }
            }
            isLoaded = true;

            isLoaded = true;
            listUI.SetActive(false);
            locatingUI.SetActive(false);
        }
        //}

        IEnumerator Send()
        {
            string ip = "192.168.0.13";
            isDownloaded = false;
            www = new WWW("http://" + ip + "/~kim/searchobject.php?ROOMID=" + roomId);


            yield return www;

            Debug.Log(www.text);

            itemdata = JsonMapper.ToObject(www.text);

            for (int i = 0; i < itemdata.Count; i++)
            {
                Debug.Log(itemdata[i]["OBJECTID"].ToString() + "식별");
                Debug.Log(itemdata[i]["objectx"].ToString());
            }

        }

        // Update is called once per frame
    }
}

