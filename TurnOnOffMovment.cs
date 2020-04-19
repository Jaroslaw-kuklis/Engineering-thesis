using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnOffMovment : MonoBehaviour
{
    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.PrimaryThumbstick))
        {
            GetComponent<OVRPlayerController>().enabled = false;
        }
        if (OVRInput.Get(OVRInput.Button.Start))
        {
            GetComponent<OVRPlayerController>().enabled = true;
        }
    }
}
