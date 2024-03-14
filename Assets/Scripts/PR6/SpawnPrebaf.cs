using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPrebaf : MonoBehaviour
{
    public Rigidbody prebafToSpawn;
    public KeyCode spawnKey;
    bool isInRange = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isInRange && Input.GetKeyDown(spawnKey))
        {
            Instantiate(prebafToSpawn, transform.position + Vector3.up * 4, transform.rotation);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        isInRange = true;
    }

    private void OnTriggerExit(Collider other)
    {
        isInRange = false;
    }
}
