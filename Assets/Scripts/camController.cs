using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camController : MonoBehaviour
{
    [SerializeField]
    Transform transPlayer;
    
    void Update()
    {
        transform.position = transPlayer.position;
    }
}
