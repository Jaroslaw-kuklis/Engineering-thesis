using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeasuringMeters : PulseFigure
{
    public GameObject cube1;
    public GameObject cube2;
    public float distance;
    private void Update()
    {
        
        distance = Vector3.Distance(cube1.transform.position, cube2.transform.position);
        
    }
}
