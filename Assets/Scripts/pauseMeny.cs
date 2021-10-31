using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMeny : MonoBehaviour
{

    public static bool isGamePaused = false;

    [SerializeField]
    GameObject pauseMenyUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isGamePaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

   public void Resume()
    {
        pauseMenyUI.SetActive(false);
        Time.timeScale = 1f;
        isGamePaused = false;
    }

   public void Pause()
    {
        pauseMenyUI.SetActive(true);
        Time.timeScale = 0f;
        isGamePaused = true;
    }

    
    public void LoadMeny()
    {
        SceneManager.LoadScene("Meny");
    }

    public void QuitGame()
    { 
        Application.Quit();
        Debug.Log("Stopper spill");
    }
}
