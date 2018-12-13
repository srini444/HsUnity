using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;

    private void Awake()
    {
        pauseMenuUI.SetActive(false);
        
    }
    // Use this for initialization
    void Start()
    {

        
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

   public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        pauseMenuUI.SetActive(false);
        Debug.Log("Load Menu");
    }

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

   public void close()
   {
        Time.timeScale = 1f;
        pauseMenuUI.SetActive(false);
   }
  

}
