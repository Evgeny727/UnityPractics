using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            rb.AddForce(Vector3.forward * 5);
        if (Input.GetKey(KeyCode.S))
            rb.AddForce(Vector3.back * 5);
        if (Input.GetKey(KeyCode.A))
            rb.AddForce(Vector3.left * 5);
        if (Input.GetKey(KeyCode.D))
            rb.AddForce(Vector3.right * 5);
    }
}
