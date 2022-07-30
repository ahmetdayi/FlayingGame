using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleProduct : MonoBehaviour
{
    public GameObject obstacle;
    
    Transform firstObstacleTransform;
    GameObject firstObstacle;
    
    float newObstacleX;
    
    float newObstacleY;
    
    float newObstacleZ;
    
    bool isNegatif = false;
    
    Transform planeTransform;

    ArrayList xPositionObstacles = new ArrayList();
    float planeX;

    void Start()
    {
        firstObstacle = GameObject.Find("Obstacle");
        firstObstacleTransform = firstObstacle.transform;
        planeTransform = GameObject.Find("EaglePlane").transform;
        newObstacleX = firstObstacleTransform.position.x;
        newObstacleY = firstObstacleTransform.position.y;
       
            InvokeRepeating("ProductObstacle", 0.0f,1);
        

        InvokeRepeating("DeleteObstacle", 0.0f, 0.1f);
    }

    // Update is called once per frame
    void Update()
    {
       
        planeX = planeTransform.position.x+18f ;
    }

  

    void ProductObstacle()
    {
        float numberY;
        isNegatif = !isNegatif;
        if (isNegatif)
        {
            numberY = Random.Range(-20f, -7);
        }
        else{
             numberY= Random.Range(7f, 20f);
        }
       
        
        float numberX = Random.Range( -20f, -16f);
        newObstacleX +=numberX;
        newObstacleY += numberY;
        
        GameObject newObject=  Instantiate(obstacle,new Vector3(newObstacleX,newObstacleY,-0.5f),Quaternion.identity);
        xPositionObstacles.Add(firstObstacle);
        xPositionObstacles.Add(newObject);
       
       
        }

    void DeleteObstacle()
    {

        foreach (GameObject xObstacle in xPositionObstacles)
        {
            
            if (planeX <= xObstacle.transform.position.x)
            {
                xObstacle.SetActive(false);
                

            }
        }
    }
    }

    

