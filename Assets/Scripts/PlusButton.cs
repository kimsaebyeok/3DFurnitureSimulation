using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlusButton : MonoBehaviour
{
    public GameObject category;
    public GameObject offButton;
    // Start is called before the first frame update

     public void OnClick()
    {
        TurnOnCategory();
    }

    public void TurnOnCategory()
    {
        category.SetActive(true);
        offButton.SetActive(true);
        gameObject.SetActive(false);
    }
}
