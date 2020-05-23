using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aaa : MonoBehaviour
{
    string test = "";
    WWW www;
    public bool isDownloaded = false;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Send());
    }

    IEnumerator Send()
    {
        string ip = "172.30.53.36";
        isDownloaded = false;
        www = new WWW("http://172.30.53.36/~kim/search.php?roomx=123&roomy=456&roomz=789&address=서울특별시");
        yield return www;
        if (www.isDone) isDownloaded = true;

        Debug.Log(www.text);
    }

    // Update is called once per frame
    void Update()
    {
        // if(isDownloaded == false) Debug.Log(" Progress : " + www.progress * 100 + "%");
        // else Debug.Log(www.text);

    }
}
