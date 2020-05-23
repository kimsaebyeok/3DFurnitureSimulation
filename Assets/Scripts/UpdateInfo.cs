using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class UpdateInfo : MonoBehaviour
{
    public Transform target;
    public InputField length;
    public InputField width;
    public InputField height;
    public bool isUpdated;
    private float lastX,lastY,lastZ;
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
            if (length.text == "" || width.text == "" || height.text == "")
            { return; }
            else
            {
                target.localScale = new Vector3(Convert.ToSingle(length.text) * target.localScale.x / lastX,
                                                                            Convert.ToSingle(width.text) * target.localScale.y / lastZ,
                                                                           Convert.ToSingle(height.text) * target.localScale.z / lastY);
                lastX = Convert.ToSingle(length.text);
                lastY = Convert.ToSingle(height.text);
                lastZ = Convert.ToSingle(width.text);
                isUpdated = false;
            }
        }
    }

    public void Init()
    {
        lastX = target.transform.GetComponent<MeshFilter>().mesh.bounds.size.x;
        lastZ = target.transform.GetComponent<MeshFilter>().mesh.bounds.size.z;
        lastY = target.transform.GetComponent<MeshFilter>().mesh.bounds.size.y;

        length.text = lastX.ToString();
        width.text = lastZ.ToString();
        height.text = lastY.ToString();
    }
}
