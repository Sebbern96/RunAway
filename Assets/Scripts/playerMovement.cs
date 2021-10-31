using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{


    [SerializeField]
    Vector3 v3F;
    [SerializeField]
    KeyCode inputPositive;
    [SerializeField]
    KeyCode inputNegative;

   


    void FixedUpdate()
    {
        if (Input.GetKey(inputPositive))
            GetComponent<Rigidbody>().velocity += v3F;

        if (Input.GetKey(inputNegative))
            GetComponent<Rigidbody>().velocity -= v3F;

        
    }  


}
