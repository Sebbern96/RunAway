using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class destroyCollision : MonoBehaviour
{

    [SerializeField]
    string createdTag;

    

    [SerializeField]
    bool otherDestruct = false;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == createdTag)
        {
            
            if (otherDestruct)
                Destroy(collision.gameObject);
        }
    }
}
