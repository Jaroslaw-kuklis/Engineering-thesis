using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GripperMove : LimitMoveGrip1
{
    public float Speed = 0.1f;
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Limiter1")
        {
            Speed = 0;
        }       
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Limiter1")
        {
            Speed = 0.1f;
        }        
    }

    void Update()
    {
        if(HandCheck==false)
        {
            if (OVRInput.Get(OVRInput.Button.One))
            {
                transform.position += -transform.right * Time.deltaTime * SpeedCentre;
            }

            if (OVRInput.Get(OVRInput.Button.Three))
            {
                transform.position += transform.right * Time.deltaTime * Speed;
            }
        }
        


        if (Input.GetKey(KeyCode.A))
        {
            transform.position += -transform.right * Time.deltaTime * SpeedCentre;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += transform.right * Time.deltaTime*Speed;
        }       
    }
}
