using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class constantVelocity : MonoBehaviour
{
    [SerializeField]
    Vector3 force;


    void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity += force;
    }
}
