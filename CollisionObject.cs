using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionObject : DetectGrip2
{  
    private void OnCollisionEnter(Collision collision)
    {
        
            if (OVRInput.Get(OVRInput.Button.Three) && HandCheck == false)
            {
                transform.parent = null;
            }
        
        
    }
}
