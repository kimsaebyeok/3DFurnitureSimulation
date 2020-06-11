using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;

public class Save : MonoBehaviour
{
    public GameObject plane;
    public GameObject list;
    public string info;
    WWW www;

    GameObject userRoomInfo;
    GameObject createdRoomInfo;
    GameObject roomInfo;
    RoomInfo ri;
    UserRoomInfo ur;
    CreatedRoomInfo cr;
    public bool isUR = true;
    public int x, y, z;
    public string addressDoSi;
    public string address;
    public int roomId;
    public string roomName;
    public string password;

    public string rid;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LaSend());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick()
    {

        //StartCoroutine(Send());

        
        string ip = "192.168.0.13";

        LocatedListBlock[] blocks = list.GetComponentsInChildren<LocatedListBlock>();
        for (int i = 0; i < blocks.Length; i++)
        {
            info = "http://" + ip + "//~kim/addobject.php?ROOMID=" + rid;
            info = info + "&objectx=" + blocks[i].Position.x.ToString();
            info = info + "&objecty=" + blocks[i].Position.y.ToString();
            info = info + "&objectz=" + blocks[i].Position.z.ToString();
            info = info + "&objectkey=" + blocks[i].Info.FurnitureNumber.ToString();
            info = info + "&objectsizex=" + ((int)blocks[i].Scale.x).ToString();
            info = info + "&objectsizey=" + ((int)blocks[i].Scale.y).ToString();
            info = info + "&objectsizez=" + ((int)blocks[i].Scale.z).ToString();
            info = info + "&objectrotation=" + blocks[i].target.transform.rotation.y.ToString();
            Debug.Log(info);
            StartCoroutine(ObSend());
        }

    }
    IEnumerator ObSend()
    {
        www = new WWW(info);
        yield return www;
    }

    IEnumerator LaSend()
    {
        string ip = "192.168.0.13";

        www = new WWW("http://" + ip + "/~kim/searchlast.php");
        //Debug.Log("안녕123123");
        yield return www;

        JsonData itemdata = JsonMapper.ToObject(www.text);

        // Debug.Log(www.text);

        for (int i = 0; i < itemdata.Count; i++)
        {
            Debug.Log(itemdata[i]["ROOMID"].ToString() + "병수");
            rid = itemdata[i]["ROOMID"].ToString();
            Debug.Log(rid + "rid");
        }
    }
    IEnumerator Send()
    {


        userRoomInfo = GameObject.Find("UserRoomInformation");
        roomInfo = GameObject.Find("RoomInformation");
        createdRoomInfo = GameObject.Find("CreatedRoomInformation");
        if (createdRoomInfo != null)
        {
            //isUR = false;
            createdRoomInfo = GameObject.Find("CreatedRoomInformation");
            cr = createdRoomInfo.GetComponent<CreatedRoomInfo>();
            addressDoSi = cr.addressDoSi;
            address = cr.address;
            x = cr.x;
            y = cr.y;
            z = cr.z;
           // roomId = cr.roomId;
            password = cr.password;
            //Debug.Log(roomId + "fuck");
        }
        string ip = "192.168.0.13";

        www = new WWW("http://" + ip + "/~kim/add.php?roomx=" + x + "&roomy= " + y + " &roomz= " + z + " &addressdosi= " + addressDoSi + "&address=" + address + " &password=" + password);
        //Debug.Log("안녕123123");
        yield return www;

        JsonData itemdata = JsonMapper.ToObject(www.text);

       // Debug.Log(www.text);

        for (int i = 0; i < itemdata.Count; i++)
        {
            Debug.Log(itemdata[i]["ROOMID"].ToString() + "병수");
            int.TryParse(itemdata[i]["ROOMID"].ToString(), out cr.roomId);
            
        }
    }
}

