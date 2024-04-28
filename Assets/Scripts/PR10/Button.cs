using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    public GameObject panel;
    public GameObject image;
    public Sprite newImage;
    
    public void Close()
    {
        panel.SetActive(false);
    }

    public void ChangeImage()
    {
        image.GetComponent<Image>().sprite = newImage;
    }
}
