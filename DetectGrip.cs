using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectGrip : DetectGrip2
{
    public static bool Check = false;
    public static bool Drop = false;

    private void OnCollisionEnter(Collision collision)
    {
        if(HandCheck==false)
        {
            if (collision.gameObject.name == "Cube" && OVRInput.Get(OVRInput.Button.One))
            {
                collision.transform.parent = transform.parent;
                collision.rigidbody.isKinematic = true;
                collision.rigidbody.useGravity = false;
                Check = true;

                if (Drop == true)
                {
                    collision.transform.parent = null;
                    collision.rigidbody.isKinematic = false;
                    collision.rigidbody.useGravity = true;
                }
            }

            if (collision.gameObject.name == "LimiterDrop1")
            {
                Check = false;
                Drop = false;
            }
        }else
        if(collision.gameObject.name == "Cube" )
        {                      
                collision.transform.parent = transform.parent;
                collision.rigidbody.isKinematic = true;
                collision.rigidbody.useGravity = false;
                Check = true;

                if (Drop == true)
                {
                    collision.transform.parent = null;
                    collision.rigidbody.isKinematic = false;
                    collision.rigidbody.useGravity = true;
                }                             
        } 

        if(collision.gameObject.name=="LimiterDrop1")
        {
            Check = false;
            Drop = false;
        }
    }
}
