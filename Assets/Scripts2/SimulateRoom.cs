using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimulateRoom : MonoBehaviour
{
    public Text addressDoSi;
    public CreatedRoomInfo cr;
    public InputField password;
    public InputField address;
    public InputField xValue;
    public InputField yValue;
    public InputField zValue;
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
        int x = 0, y = 0, z = 0;
        bool result;
        password.text = password.text.Trim();
        address.text = address.text.Trim();
        xValue.text = xValue.text.Trim();
        yValue.text = yValue.text.Trim();
        zValue.text = zValue.text.Trim();

        if (password.text == "" || address.text == "" || xValue.text == "" || yValue.text == "" || zValue.text == "")
            return;

        result = int.TryParse(xValue.text, out x);
        if (!result)
        {
            xValue.text = "";
            return;
        }

        result = int.TryParse(yValue.text, out y);
        if (!result)
        {
            yValue.text = "";
            return;
        }

        result = int.TryParse(zValue.text, out z);
        if (!result)
        {
            zValue.text = "";
            return;
        }

        cr.password = password.text;
        cr.addressDoSi = addressDoSi.text;
        cr.address = address.text;
        cr.x = x;
        cr.y = y;
        cr.z = z;

        cr.call();
    }
}
