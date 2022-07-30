using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CollisionManager : MonoBehaviour
{
     public GameObject gameOverScene;
    public AudioSource audioSource;
    public AudioClip clip;

    private void OnCollisionEnter(Collision collision)
    {
        audioSource.loop = false;
        audioSource.clip = clip;
        audioSource.Play();
        Time.timeScale = 0.0f;
        gameOverScene.SetActive(true);
    }

    
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
