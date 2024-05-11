using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PR14 : MonoBehaviour
{
    public GameObject BoxPrebaf;
    public GameObject SpherePrebaf;
    public GameObject PanelMenu;
    public GameObject SpawnObject;
    bool isActive;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (!isActive)
            {
                PanelMenu.SetActive(true);
                isActive = true;
            }
            else
            {
                PanelMenu.SetActive(false);
                isActive = false;
            }
        }
    }

    public void CreateBox()
    {
        Instantiate(BoxPrebaf, SpawnObject.transform.position, SpawnObject.transform.rotation);
    }

    public void CreateSphere()
    {
        Instantiate(SpherePrebaf, SpawnObject.transform.position, SpawnObject.transform.rotation);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
