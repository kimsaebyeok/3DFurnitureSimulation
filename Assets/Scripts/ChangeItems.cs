using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ChangeItems : MonoBehaviour
{
    GameObject nameScrollView = GameObject.Find("Name Scroll View");
    GameObject cardP;
    // Start is called before the first frame update
    void Start()
    {
        cardP = Resources.Load<GameObject>("FurnitureCard");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeItem(bool isSample, int room)
    {
        if (isSample)
        {
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader("Assets/Resources/SampleFurnitureInfo.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] info = line.Split('\x020');

                if (Int32.Parse(info[2]) != room)
                    continue;

                GameObject card = Instantiate(cardP);
                card.GetComponent<FurnimureCardInit>().CardInit(info[0]);
                card.transform.parent = nameScrollView.transform;
                card.SetActive(true);
            }
        }
    }
}
