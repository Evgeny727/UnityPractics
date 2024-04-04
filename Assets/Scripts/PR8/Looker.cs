using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Looker : MonoBehaviour
{
    public GameObject guard;
    float reset = 5;
    bool movingDown;

    // Update is called once per frame
    void Update()
    {
        if (!movingDown)
            transform.position -= new Vector3(0, 0, 0.01f);
        else
            transform.position += new Vector3(0, 0, 0.01f);

        if (transform.position.z > 10)
            movingDown = false;
        else if (transform.position.z < -10)
            movingDown = true;

        reset -= Time.deltaTime;
        if (reset < 0)
        {
            guard.GetComponent<Guard>().enabled = false;
            GetComponent<SphereCollider>().enabled = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            guard.GetComponent<Guard>().enabled = true;
            reset = 5;
            GetComponent<SphereCollider>().enabled = false;
        }
    }
        
}
