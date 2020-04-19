using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnOffControl : MonoBehaviour
{

    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.PrimaryThumbstick))
        {
            GetComponent<HandMove>().enabled = true;
        }
        if (OVRInput.Get(OVRInput.Button.Start))
        {
            GetComponent<HandMove>().enabled = false;
        }
    }
}
