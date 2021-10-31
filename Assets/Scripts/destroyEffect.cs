using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyEffect : MonoBehaviour
{
    [SerializeField]
    float timer;


    

    
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
            Destroy(this.gameObject);
    }
}
