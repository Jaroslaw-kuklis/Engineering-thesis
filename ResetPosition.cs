using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPosition : MonoBehaviour
{
    Vector3 originalPos;
    Quaternion originalRot;
    void Start()
    {
        originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        
        originalRot = new Quaternion(gameObject.transform.rotation.x, gameObject.transform.rotation.y, gameObject.transform.rotation.z,0f);
        

    }

    private void Update()
    {
        if (OVRInput.Get(OVRInput.Button.SecondaryThumbstick))
        {
            transform.parent = null;
            gameObject.transform.position = originalPos;
            gameObject.transform.rotation = originalRot;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Table (1)")
        {
            gameObject.transform.rotation = originalRot;
            gameObject.transform.position = originalPos;
        }
    }

}
