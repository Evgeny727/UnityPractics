using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_open : MonoBehaviour
{
    public KeyCode spawnKey;
    bool isInRange = false;
    bool isOpen = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isOpen && isInRange && Input.GetKeyDown(spawnKey))
        {
            transform.position = transform.localPosition - new Vector3(0,6,0);
            isOpen = true;
        }
        else if (isOpen && isInRange && Input.GetKeyDown(spawnKey))
        {
            transform.position = transform.localPosition + new Vector3(0, 6, 0);
            isOpen = false;
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
