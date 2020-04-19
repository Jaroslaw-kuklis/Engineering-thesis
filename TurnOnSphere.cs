using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnSphere : MonoBehaviour
{
    public GameObject Sphere;

    void FixedUpdate()
    {
        if (OVRInput.Get(OVRInput.Button.SecondaryThumbstick))
        {
            Sphere.SetActive(true);
        }

    }
}
