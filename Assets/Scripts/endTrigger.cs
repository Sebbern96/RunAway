using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class endTrigger : MonoBehaviour
{
    public GameObject Endscreen;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Endscreen.gameObject.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void nextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("Next lvl loaded!");
        Time.timeScale = 1f;
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
