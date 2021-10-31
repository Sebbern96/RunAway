using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackPlayer : MonoBehaviour
{
    [SerializeField]
    Transform forward;

    [SerializeField]
    float speed;

    Rigidbody rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if(forward == null)
        {
            forward = FindObjectOfType<playerMovement>().transform;
        }
    }

   
    void Update()
    {
        rb.velocity += (forward.position - transform.position).normalized * speed * Time.deltaTime;
    }
}
