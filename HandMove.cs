using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandMove : MonoBehaviour
{
    public float Speed = 10f;
    public GameObject[] Axis = new GameObject[7];
    
    private void Start()
    {
        GetComponent<HandMove>().enabled = false;       
    }

    void Update()
    {       
        if (OVRInput.Get(OVRInput.Button.SecondaryThumbstick))
            GetComponent<HandMove>().enabled = false;        

        Vector2 primaryAxis = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick);
        Vector2 primaryAxis2 = OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick);
               
        if (gameObject.name == "Pivot Axis 1")
        {
            if (primaryAxis.x > 0f)
            {
                transform.Rotate(Vector2.down * Time.deltaTime * Speed);
            }
            if (primaryAxis.x < 0f)
            {
                transform.Rotate(Vector2.up * Time.deltaTime * Speed);
            }
        }

        if (gameObject.name=="Pivot Axis 2")
        {
            if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
            {
                transform.Rotate(Vector2.left * Time.deltaTime * Speed);
            }

            if (OVRInput.Get(OVRInput.Button.SecondaryIndexTrigger))
            {
                transform.Rotate(Vector2.right * Time.deltaTime * Speed);
            }
        }
             
        if (gameObject.name == "Pivot Axis 3")
        {
            if (OVRInput.Get(OVRInput.Button.PrimaryHandTrigger))
            {
                transform.Rotate(Vector2.left * Time.deltaTime * Speed);
            }
            if (OVRInput.Get(OVRInput.Button.SecondaryHandTrigger))
            {
                transform.Rotate(Vector2.right * Time.deltaTime * Speed);
            }
        }

        if (gameObject.name == "Pivot Axis 4")
        {
            if (OVRInput.Get(OVRInput.Touch.PrimaryThumbRest))
            {
                transform.Rotate(Vector2.down * Time.deltaTime * Speed);
            }
            if (OVRInput.Get(OVRInput.Touch.SecondaryThumbRest))
            {
                transform.Rotate(Vector2.up * Time.deltaTime * Speed);
            }
        }

        if (gameObject.name == "Pivot Axis 5")
        {
            if (OVRInput.Get(OVRInput.Button.Four))
            {
                transform.Rotate(Vector2.left * Time.deltaTime * Speed);
            }
            if (OVRInput.Get(OVRInput.Button.Two))
            {
                transform.Rotate(Vector2.right * Time.deltaTime * Speed);
            }
        }

        if (gameObject.name == "Pivot Axis 6")
        {
            if (primaryAxis2.x > 0f)
            {
                transform.Rotate(Vector2.down * Time.deltaTime * Speed);
            }
            if (primaryAxis2.x < 0f)
            {
                transform.Rotate(Vector2.up * Time.deltaTime * Speed);
            }
        }
    }
}
