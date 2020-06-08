using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixRegularAngle : MonoBehaviour
{
    public Transform target;
    private int angleNumber;
    // Start is called before the first frame update
    void Start()
    {
        angleNumber = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        switch (angleNumber)
        {
            case 0 :
                {
                    target.transform.rotation = Quaternion.Euler(target.transform.rotation.eulerAngles.x, 45, target.transform.rotation.eulerAngles.z);
                    angleNumber++;
                    break;
                }
            case 1:
                {
                    target.transform.rotation = Quaternion.Euler(target.transform.rotation.eulerAngles.x, 135, target.transform.rotation.eulerAngles.z);
                    angleNumber++;
                    break;
                }
            case 2:
                {
                    target.transform.rotation = Quaternion.Euler(target.transform.rotation.eulerAngles.x, 225, target.transform.rotation.eulerAngles.z);
                    angleNumber++;
                    break;
                }
            case 3:
                {
                    target.transform.rotation = Quaternion.Euler(target.transform.rotation.eulerAngles.x, 315, target.transform.rotation.eulerAngles.z);
                    angleNumber = 0;
                    break;
                }
        }
    }
}
