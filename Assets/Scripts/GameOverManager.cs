using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RestartBtn()
    {
        SceneManager.LoadScene("GameScene");

        Time.timeScale = 1f;
       
    }

    public void MenuBtn()
    {
        SceneManager.LoadScene("MenuScene");
        Time.timeScale = 1f;
    }
}
