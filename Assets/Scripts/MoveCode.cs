using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCode : MonoBehaviour
{
    
    float upDownRotate;
    float rightleftTranslate;
    public float rotateSpeed;
    public float translateSpeed;
    public float planeSpeed;
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        rightleftTranslate = Input.GetAxis("Horizontal")*Time.deltaTime* translateSpeed;
        upDownRotate = -Input.GetAxis("Vertical")*Time.deltaTime*rotateSpeed;

        transform.Translate(new Vector3(-planeSpeed * Time.deltaTime, 0, 0));
        transform.Rotate(Vector3.forward * upDownRotate);
        transform.Translate(Vector3.forward *rightleftTranslate );
    }
    void Update()
    {
        
    }
}
