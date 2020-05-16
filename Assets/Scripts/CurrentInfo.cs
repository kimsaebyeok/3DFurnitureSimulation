using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentInfo : MonoBehaviour
{
    public bool isSample = true;
    private GameObject namePanel = GameObject.Find("Name Scroll View");
    public enum Category
    {
        all = 0,
        livingroom = 1,
        bedroom = 2,
        kitchen = 3,
        toilet = 4,
        balcony = 5
    }
    public Category current = Category.all;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Init()
    {
        current = Category.all;

    }
}
