using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkSimulation : DetectGrip
{
    public GameObject[] points;

    
    int current = 0;
    public float rotSpeed;
    public float speed;
    float radius = 0.1f;

    /*public float Force = 1000;
    public float Mass = 0;
    private float Acceleration;
    public float Velocity;
    private float velMax = 7f;*/

    public Transform Robot3;
    public Transform Axis6;
    public Transform Grip1;
    public Transform Grip2;

    private void Start()
    {
        GetComponent<WorkSimulation>().enabled = true;
    }


    public void FixedUpdate()
    {
        /*if (Velocity < velMax)
        {
            Acceleration = ((Force + (Mass * 10)) / Mass);
            Velocity = (Acceleration * Time.deltaTime);
            if (Velocity >= velMax)
                Velocity = velMax;
        }*/

        if(GetComponent<WorkSimulation>().enabled == true)
        {
            HandCheck = true;
        }


        if (gameObject.active)
        {
            transform.SetParent(Robot3);          
        }
               
        if(GetComponent<WorkSimulation>().enabled==true)
        {
            gameObject.GetComponent<SphereCollider>().enabled = false;            
        }

        if (OVRInput.Get(OVRInput.Button.PrimaryThumbstick))
        {
            current = 0;            
            HandCheck = false;
            transform.SetParent(Axis6);
            gameObject.SetActive(false);                     
        }
                
        transform.position = Vector3.MoveTowards(transform.position, points[current].transform.position, Time.deltaTime * speed);
        transform.rotation = Quaternion.Slerp(transform.rotation, points[current].transform.rotation, Time.deltaTime * rotSpeed);

        if (current == 0 && transform.position == points[current].transform.position)
        {
            if (Check == true || Check2 == true)
            {
                Grip1.transform.position -= -Vector3.right * Time.deltaTime * 0.05f;
                Grip2.transform.position -= Vector3.right * Time.deltaTime * 0.05f;
            }
        }

        if (current == 2 && transform.position == points[current].transform.position)
        {
            if (Check == false || Check2 == false)
            {
                Grip1.transform.position += -Vector3.right * Time.deltaTime * 0.05f;
                Grip2.transform.position += Vector3.right * Time.deltaTime * 0.05f;
            }                         
        }

        if (current == 6 && transform.position == points[current].transform.position)
        {            
            if (Check== true)
            {
                Drop = true;
                Grip1.transform.position -= -Vector3.right * Time.deltaTime * 0.05f;
            }
            if (Check2 == true)
            {
                Drop2 = true;
                Grip2.transform.position -= Vector3.right * Time.deltaTime * 0.05f;
            }                   
        }

        if (current == 0 && transform.rotation == points[current].transform.rotation && transform.position == points[current].transform.position)
        {
            if (Check == false && Check2 == false)
            current = current + 1;           
        }

        if (current == 1 && transform.position == points[current].transform.position)
        {              
            current = current + 1;
            speed = 0.5f;
        }

        if (current == 2 && transform.position == points[current].transform.position && Check == true && Check2==true)
        {                     
            current = current + 1;         
        }

        if (current == 3 && transform.position == points[current].transform.position)
        {
            current = current + 1;
            speed = 3f;
        }

        if (current == 4 && transform.position == points[current].transform.position)
        {
            current = current + 1;
        }

        if (current == 5 && transform.position == points[current].transform.position )
        {
            current = current + 1;
            speed = 0.5f;
        }

        if (current == 6 && transform.position == points[current].transform.position && Check == false && Check2 == false)
        {
            speed = 3f;
            current = 0;
        }
        Debug.Log(HandCheck);
    }
}
