using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartButton : MonoBehaviour
{
    [SerializeField]
    KeyCode rButton;

    void Update()
    {
        if (Input.GetKey(rButton))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
