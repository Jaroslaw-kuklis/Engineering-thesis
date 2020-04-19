using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Simulation : MonoBehaviour
{
    public GameObject[] points;
    private int current = 0;

    public float Force = 1000;
    public float Mass = 0;
    private float Acceleration;
    public float Velocity;
    private float velMax = 7f;

    public float rotSpeed;
    public float speed;
    private float radius = 0.1f;

    public Text timerText;
    private bool startTime = false;
    private bool finished = false;
    protected static float t;

    

  
    private void Update()
    {
        if (Velocity < velMax)
        {
            Acceleration = ((Force + (Mass * 10)) / Mass);
            Velocity = (Acceleration * t);
            if (Velocity >= velMax)
                Velocity = velMax;
        }           
        
        
        if(current==0)
        transform.position = Vector3.MoveTowards(transform.position, points[current].transform.position, Time.deltaTime * speed);

        if (current == 0 && transform.position == points[current].transform.position)
        {          
            speed = 0;
            if(Input.GetKey(KeyCode.Z))
            {               
                current = current + 1;
                startTime = true;
            }
            
        }
        if(current==1)
        {                   
            transform.position = Vector3.MoveTowards(transform.position, points[current].transform.position, Time.deltaTime * Velocity);
            if (transform.position == points[current].transform.position)
            {

                Debug.Log("velocity:" + Velocity + "    czas:" + t + "    current:" + current);
                current++;
            }
                
        }
        if(current==2)
        {
            transform.position = Vector3.MoveTowards(transform.position, points[current].transform.position, Time.deltaTime * Velocity);
            if (transform.position == points[current].transform.position)
            {

                Debug.Log("velocity:" + Velocity + "    czas:" + t + "    current:" + current);
                current++;
            }
        }
        if (current == 3)
        {
            transform.position = Vector3.MoveTowards(transform.position, points[current].transform.position, Time.deltaTime * Velocity);
            if (transform.position == points[current].transform.position)
            {

                Debug.Log("velocity:" + Velocity + "    czas:" + t + "    current:" + current);
                current++;
            }
        }
        if (current == 4)
        {
            transform.position = Vector3.MoveTowards(transform.position, points[current].transform.position, Time.deltaTime * Velocity);
            if (transform.position == points[current].transform.position)
            {

                Debug.Log("velocity:" + Velocity + "    czas:" + t + "    current:" + current);
                current++;
            }
        }
        if (current == 5)
        {
            transform.position = Vector3.MoveTowards(transform.position, points[current].transform.position, Time.deltaTime * Velocity);
            if (transform.position == points[current].transform.position)
            {

                Debug.Log("velocity:" + Velocity + "    czas:" + t + "    current:" + current);
                current++;
            }
        }
        if (current == 6)
        {
            transform.position = Vector3.MoveTowards(transform.position, points[current].transform.position, Time.deltaTime * Velocity);
            if (transform.position == points[current].transform.position)
            {

                Debug.Log("velocity:" + Velocity + "    czas:" + t + "    current:" + current);
                current++;
            }
        }
        if (current == 7)
        {
            transform.position = Vector3.MoveTowards(transform.position, points[current].transform.position, Time.deltaTime * Velocity);
            if (transform.position == points[current].transform.position)
            {
                Debug.Log("velocity:" + Velocity + "    czas:" + t + "    current:" + current);
                current++;
            }
        }
        if (current == 8)
        {
            transform.position = Vector3.MoveTowards(transform.position, points[current].transform.position, Time.deltaTime * Velocity);
            if (transform.position == points[current].transform.position)
            {

                Debug.Log("velocity:" + Velocity + "    czas:" + t + "    current:" + current);
                current++;
            }
        }
        if (current == 9)
        {
            transform.position = Vector3.MoveTowards(transform.position, points[current].transform.position, Time.deltaTime * Velocity);
            if (transform.position == points[current].transform.position)
            {

                Debug.Log("velocity:" + Velocity + "    czas:" + t + "    current:" + current);
                current++;
            }
        }

        if (current == 10)
        {            
            transform.position = Vector3.MoveTowards(transform.position, points[current].transform.position, Time.deltaTime * Velocity);
            if(transform.position == points[current].transform.position)
            {
                Debug.Log("velocity:" + Velocity + "    czas:" + t + "    current:" + current);
                current++;

            }
            
        }
        if (current == 11)
        {
            transform.position = Vector3.MoveTowards(transform.position, points[current].transform.position, Time.deltaTime * Velocity);
            if (transform.position == points[current].transform.position)
            {
                Debug.Log("velocity:" + Velocity + "    czas:" + t + "    current:" + current);
                current++;

            }

        }
        if (current == 12)
        {
            transform.position = Vector3.MoveTowards(transform.position, points[current].transform.position, Time.deltaTime * Velocity);
            if (transform.position == points[current].transform.position)
            {
                Debug.Log("velocity:" + Velocity + "    czas:" + t + "    current:" + current);
                current++;

            }

        }
        if (current == 13)
        {
            transform.position = Vector3.MoveTowards(transform.position, points[current].transform.position, Time.deltaTime * Velocity);
            if (transform.position == points[current].transform.position)
            {
                Debug.Log("velocity:" + Velocity + "    czas:" + t + "    current:" + current);
                current++;

            }

        }
        if (current == 14)
        {
            transform.position = Vector3.MoveTowards(transform.position, points[current].transform.position, Time.deltaTime * Velocity);
            if (transform.position == points[current].transform.position)
            {
                Debug.Log("velocity:" + Velocity + "    czas:" + t + "    current:" + current);
                current++;

            }

        }
        if (current == 15)
        {
            transform.position = Vector3.MoveTowards(transform.position, points[current].transform.position, Time.deltaTime * Velocity);
            if (transform.position == points[current].transform.position)
            {
                Debug.Log("velocity:" + Velocity + "    czas:" + t + "    current:" + current);
                Velocity = 0;
                startTime = false;
               
            }

        }

        //Timer
        if (startTime)
            t += Time.deltaTime;
        string seconds = (t).ToString();
        timerText.text ="Time: " + seconds;
    }

    /*private void OnTriggerEnter(Collider other)
    {
        
        if (GameObject.Find("wartosc1 (1)"))
        {
            Debug.Log(speed + " 2a" );
        }
        if (GameObject.Find("wartosc1 (2)"))
        {
            Debug.Log(speed + " 3a");
        }
        if (GameObject.Find("wartosc1 (3)"))
        {
            Debug.Log(speed + " 4a");
        }
        if (GameObject.Find("wartosc1 (4)"))
        {
            Debug.Log(speed + " 5a");
        }
    }*/
   
}
