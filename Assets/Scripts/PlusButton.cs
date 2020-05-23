using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlusButton : MonoBehaviour
{
    public GameObject category;
    // Start is called before the first frame update

     public void OnClick()
    {
        TurnOnCategory();
    }

    public void TurnOnCategory()
    {
        category.SetActive(true);
        gameObject.SetActive(false);
    }
}
