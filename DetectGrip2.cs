using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectGrip2 : MonoBehaviour
{
    public static bool Check2 = false;
    public static bool Drop2 = false;
    public static bool HandCheck = false;
    private void OnCollisionEnter(Collision collision)
    {
        if(HandCheck == false)
        {
            if (collision.gameObject.name == "Cube" && OVRInput.Get(OVRInput.Button.One))
            {
                collision.transform.parent = transform.parent;
                collision.rigidbody.isKinematic = true;
                collision.rigidbody.useGravity = false;
                Check2 = true;

                if (Drop2 == true)
                {
                    collision.transform.parent = null;
                    collision.rigidbody.isKinematic = false;
                    collision.rigidbody.useGravity = true;
                }
            }

            if (collision.gameObject.name == "LimiterDrop2")
            {
                Check2 = false;
                Drop2 = false;
            }
        }else
        {
            if (collision.gameObject.name == "Cube")
            {
                collision.transform.parent = transform.parent;
                collision.rigidbody.isKinematic = true;
                collision.rigidbody.useGravity = false;
                Check2 = true;

                if (Drop2 == true)
                {
                    collision.transform.parent = null;
                    collision.rigidbody.isKinematic = false;
                    collision.rigidbody.useGravity = true;
                }
            }

            if (collision.gameObject.name == "LimiterDrop2")
            {
                Check2 = false;
                Drop2 = false;
            }
        }
        
    }
}
