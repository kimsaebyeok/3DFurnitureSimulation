using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateInfo : MonoBehaviour
{
    public Transform target;
    public GameObject length;
    public GameObject width;
    public GameObject height;
    public bool isUpdated;
    // Start is called before the first frame update
    void Start()
    {
        isUpdated = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isUpdated)
        {
            //target.transform.lossyScale = 
        }
    }

    public void Init()
    {
        Debug.Log("오");
        length.GetComponent<Text>().text = target.transform.GetComponent<MeshFilter>().mesh.bounds.size.x.ToString();
        width.GetComponent<Text>().text = target.transform.GetComponent<MeshFilter>().mesh.bounds.size.z.ToString();
        height.GetComponent<Text>().text = target.transform.GetComponent<MeshFilter>().mesh.bounds.size.y.ToString();
    }
}
