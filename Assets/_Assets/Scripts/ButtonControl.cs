using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControl : MonoBehaviour
{
    public GameObject[] images; // Mảng chứa 4 Image

    public void OnButtonClick()
    {
        foreach (GameObject image in images)
        {
            image.SetActive(true); // Hiện Image
        }
    }
}