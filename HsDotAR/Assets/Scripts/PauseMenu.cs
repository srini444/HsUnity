using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;

    // Use this for initialization
    void Start()
    {
        
        pauseButton();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

   public void pauseButton()
    {
        if (GameIsPaused)
        {
            Resume();
        }
        else
        {
            Pause();
        }
    }

    void Resume()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void close()
    {
        pauseMenuUI.SetActive(false);
    }
}
