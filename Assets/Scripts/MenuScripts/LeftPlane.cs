using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftPlane : MonoBehaviour
{
    public GameObject plane;
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
       
            plane.transform.Translate(Vector3.left * Time.deltaTime);

            if (plane.transform.position.x <= -18f)
            {
                plane.transform.position = new Vector3(16f, plane.transform.position.y, plane.transform.position.z);
            }
        

    }
}
