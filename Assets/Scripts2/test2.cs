using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;


public class Data
{
    public int ROOMID;
    public int roomx;
    public int roomy;
    public int roomz;
    public string address;
    public string password;

    public Data(int id, int x, int y, int z, string address, string password)
    {
        ROOMID = id;
        roomx = x;
        roomy = y;
        roomz = z;
        address = address;
        password = password;
    }
}
public class test2 : MonoBehaviour
{
    GameObject addressInfo;
    AddressInfo ai;

    public string doo;
    public string si;

    WWW www;
    // Start is called before the first frame update
    void Start()
    {
        addressInfo = GameObject.Find("AddressInformation");
        ai = addressInfo.GetComponent<AddressInfo>();

        doo = ai.addressDo;
        si = ai.addressSi;

        Debug.Log(ai.addressDo + ai.addressSi);
        Destroy(addressInfo);

        StartCoroutine(Send());
    }

    IEnumerator Send()
    {
        string ip = "10.27.18.22";
        www = new WWW("http://" + ip + "/~kim/search.php?do="+doo+"&si="+si);
        yield return www;

        Debug.Log(www.text);

        JsonData itemdata = JsonMapper.ToObject(www.text);

        for (int i = 0; i < itemdata.Count; i++)
        {
            Debug.Log(itemdata[i]["address"].ToString());
            Debug.Log(itemdata[i]["roomx"].ToString());
            Debug.Log(itemdata[i]["roomy"].ToString());
            Debug.Log(itemdata[i]["roomz"].ToString());
            Debug.Log(itemdata[i]["password"].ToString());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
