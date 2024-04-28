using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene("Scene11_1");
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Scene11_2");
        }
    }
}
