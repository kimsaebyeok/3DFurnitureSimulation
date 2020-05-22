using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CategoryOff : MonoBehaviour
{
    public GameObject category;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        category.GetComponent<CategoryManage>().TurnOffCategory();
        gameObject.SetActive(false);
    }
}
