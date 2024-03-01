using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;

    public Transform Controller;

    public Transform Camera;

    float xRotation = 0f;

    bool isFPV = true;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("v"))
        {
            if (isFPV)
            {
                Camera.localPosition = new Vector3(0f, 0f, -7f);
            }
            else
            {
                Camera.localPosition = new Vector3(0f, 0f, 0);
            }

            isFPV = !isFPV;
        }
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        Controller.Rotate(Vector3.up * mouseX);
    }
}
