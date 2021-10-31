using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEnemy : MonoBehaviour
{

    [SerializeField]
    GameObject createOb;

    [SerializeField]
    float timeInterval;

    

    float timer = 0;

    void Start()
    {
        timer = timeInterval;
    }

    
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            timer = timeInterval;
            Instantiate(createOb, transform.position, Quaternion.identity);
        }
    }
}
