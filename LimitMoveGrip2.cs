using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitMoveGrip2 : DetectGrip2
{
    public static float SpeedCentre = 0.1f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "grip collider1")
        {
            SpeedCentre = 0f;
            
        }
        if (collision.gameObject.name == "Cube" &&  OVRInput.Get(OVRInput.Button.One))
        {
            SpeedCentre = 0f;
            collision.rigidbody.isKinematic = true;
            collision.rigidbody.useGravity = false;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "grip collider1")
        {
            SpeedCentre = 0.1f;
        }
        if(HandCheck==false)
        {
            if (collision.gameObject.name == "Cube" && OVRInput.Get(OVRInput.Button.Three))
            {
                SpeedCentre = 0.1f;
                collision.rigidbody.isKinematic = false;
                collision.rigidbody.useGravity = true;
            }
        }
        
    }
}
