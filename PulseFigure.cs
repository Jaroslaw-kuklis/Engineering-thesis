using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PulseFigure : MonoBehaviour
{
    public GameObject[] points;
    private int current = 0;

    public float Force = 1000;
    public float Mass = 0;
    private float Acceleration;
    public float Velocity;
    public float Velocity2;
    private float velMax = 7f;

    public float rotSpeed;
    public float speed;
    private float radius = 0.1f;

    public Text timerText;
    private bool startTime = false;
    private bool finished = false;
    protected static float t,t2;

    Rigidbody rb;

    public bool signVelocityDirection = true;

    private int changesStatus = 0;
    protected int stopIteration = 0;
    private void Update()
    {
        rb = GetComponent<Rigidbody>();
        
         if(signVelocityDirection )
            if (Velocity < velMax)
            {
                Acceleration = ((Force + (Mass * 10)) / Mass);
                Velocity = (Acceleration * t);
                if (Velocity >= velMax)
                    Velocity = velMax;
            }

        if(!signVelocityDirection)
        {
            if (changesStatus > stopIteration)
            {
                Velocity = Velocity - (Acceleration * t);
                if (Velocity <= 0.1f)
                {
                    t = 0;
                    signVelocityDirection = true;
                    stopIteration++;
                    Debug.Break();
                }
            }
        }
        

        if (current == 0)
            transform.position = Vector3.MoveTowards(transform.position, points[current].transform.position, Time.deltaTime * speed);

        if (current == 0 && transform.position == points[current].transform.position)
        {
            rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;                     
                current = current + 1;
                startTime = true;            
        }

        if (current == 1)
        {        
            if(Input.GetKey(KeyCode.Z))
            {
                if (startTime)
                {
                    t += Time.deltaTime;
                    t2 += Time.deltaTime;
                }
                    
                string seconds = (t2).ToString();
                timerText.text = "Time: " + seconds;

                if(stopIteration == 0)
                {
                    rb.velocity = transform.up * Velocity;
                }
                if(stopIteration>0)
                {
                    if (stopIteration % 2 == 0)
                        rb.velocity = transform.up * Velocity;
                    if (stopIteration % 2 != 0)
                        rb.velocity = -transform.up * Velocity;
                }                              
            }                         
        }
        //Debug.Log(signVelocityDirection);
        Debug.Log(Velocity);
        //Debug.Log(Acceleration);
        //Debug.Log(stopIteration);
        //Debug.Log(changesStatus);
        //Timer

    }

    public void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.name == "PointZeroPulse")
        {
            if (signVelocityDirection)
                signVelocityDirection = false;
            changesStatus++;
        }
    }
}
