using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using LitJson;

public class UserData
{
    public string roomName;
    public int ROOMID;
    public int roomX;
    public int roomY;
    public int roomZ;

    public UserData(string name, int id, int x, int y, int z)
    {
        roomName = name;
        ROOMID = id;
        roomX = x;
        roomY = y;
        roomZ = z;
    }
}
public class UserRoomList : MonoBehaviour
{
    public GameObject scrollViewContent;
    public GameObject userRoomInformationPanel;
    private GameObject panel;
    private GameObject information;
    private GameObject value;


    WWW www;
    // Start is called before the first frame update
    void Start()
    {
        panel = Instantiate(userRoomInformationPanel) as GameObject;
        panel.transform.SetParent(scrollViewContent.transform);
        information = panel.transform.Find("Information").gameObject.transform.Find("RoomNameText").gameObject;
        information.GetComponent<Text>().text = "good1";
        value = panel.transform.Find("Information").gameObject.transform.Find("Value").gameObject;
        value.GetComponent<Value>().x = 3;
        value.GetComponent<Value>().y = 2;
        value.GetComponent<Value>().z = 1;
        panel = Instantiate(userRoomInformationPanel) as GameObject;
        panel.transform.SetParent(scrollViewContent.transform);
        information = panel.transform.Find("Information").gameObject.transform.Find("RoomNameText").gameObject;
        information.GetComponent<Text>().text = "good2";
        value = panel.transform.Find("Information").gameObject.transform.Find("Value").gameObject;
        value.GetComponent<Value>().x = 1;
        value.GetComponent<Value>().y = 2;
        value.GetComponent<Value>().z = 3;


        //StartCoroutine(Send());
        //addressPanel.AddComponent<>();
    }

    IEnumerator Send()
    {
        int x, y, z;
        //string ip = "10.27.18.22";
        //www = new WWW("http://" + ip + "/~kim/search.php?do=" + Do + "&si=" + Si); -> 모두 읽어오는 코드로 변경
        yield return www;

        //Debug.Log(www.text);

        JsonData itemdata = JsonMapper.ToObject(www.text);

        for (int i = 0; i < itemdata.Count; i++)
        {
            /*panel = Instantiate(userRoomInformationPanel) as GameObject;
            panel.transform.SetParent(scrollViewContent.transform);
            information = panel.transform.Find("Information").gameObject.transform.Find("RoomNameText").gameObject;
            information.GetComponent<Text>().text = itemdata[i]["roomName"].ToString();
            value = panel.transform.Find("Information").gameObject.transform.Find("Value").gameObject;
            int.TryParse(itemdata[i]["roomx"].ToString(), out x);
            value.GetComponent<Value>().x = x;
            int.TryParse(itemdata[i]["roomy"].ToString(), out y);
            value.GetComponent<Value>().y = y;
            int.TryParse(itemdata[i]["roomz"].ToString(), out z);
            value.GetComponent<Value>().z = z;*/
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

