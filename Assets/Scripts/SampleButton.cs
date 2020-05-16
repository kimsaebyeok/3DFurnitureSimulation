using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleButton : MonoBehaviour
{
    private GameObject categoryPanel = GameObject.Find("Category Scroll View");
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
        categoryPanel.GetComponent<Script>();
    }
}
