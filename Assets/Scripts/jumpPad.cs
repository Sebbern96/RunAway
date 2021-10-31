using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpPad : MonoBehaviour
{
    private GameObject player;

    private AudioSource boing;

    Vector3 direction;

    public float jumpForce = 5f;

    private void Start()
    {
        boing = GetComponent<AudioSource>();
    }

    void Update()
    {
        direction = transform.TransformDirection(Vector3.up * jumpForce);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            boing.Play();

            player = collision.gameObject;
            player.GetComponent<Rigidbody>().AddForce(direction, ForceMode.Impulse);
        }
    }
}
