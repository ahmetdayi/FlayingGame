using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightPlane : MonoBehaviour
{
    public GameObject[] planes;
    float speed = 20f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlanes();
    }

    void MovePlanes()
    {
        foreach (GameObject plane in planes)
        {
            plane.transform.Translate(Vector3.forward*Time.deltaTime);
            
            if(plane.transform.position.x >= 10f)
            {
                plane.transform.position = new Vector3(-11f,plane.transform.position.y,plane.transform.position.z);
            }
        }

    }
}
