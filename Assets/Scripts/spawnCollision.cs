using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spawnCollision : MonoBehaviour
{

    [SerializeField]
    string createdTag;

    

    [SerializeField]
    bool otherSpawn = false;

    [SerializeField]
    GameObject goSpawn;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == createdTag)
        {

            if (otherSpawn)
                Instantiate(goSpawn, collision.transform.position, Quaternion.identity);
        }
    }
}
