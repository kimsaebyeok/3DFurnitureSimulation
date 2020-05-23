using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save : MonoBehaviour
{
    public GameObject list;
    public string info;
    WWW www;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick()
    {
        string ip = "10.27.18.22";
        LocatedListBlock[] blocks =  list.GetComponentsInChildren<LocatedListBlock>();
        for (int i = 0; i < blocks.Length; i++)
        {
            info = "http://"+ip+"//~kim/addobject.php? ROOMID=100";
            info = info + "&objectx=" + blocks[i].Position.x.ToString();
            info = info + "&objecty=" + blocks[i].Position.y.ToString();
            info = info + "&objectz=" + blocks[i].Position.z.ToString();
            info = info + "&objectkey=" + blocks[i].Info.FurnitureNumber.ToString();
            info = info + "&objectsizex=" + ((int)blocks[i].Scale.x).ToString();
            info = info + "&objectsizey=" + ((int)blocks[i].Scale.y).ToString();
            info = info + "&objectsizez=" + ((int)blocks[i].Scale.z).ToString();
            info = info + "&objectrotation=" + blocks[i].target.transform.rotation.y.ToString();
            Debug.Log(info);
            StartCoroutine(Send());
        }

        
    }

    IEnumerator Send()
    {
        www = new WWW(info);
        yield return www;

        Debug.Log(www.text);

    }
}
