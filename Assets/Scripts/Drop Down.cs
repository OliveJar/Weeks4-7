using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropDown : MonoBehaviour
{
    public GameObject Scenes;
    private bool IsMouseOver = false;
    private bool IsMouseLeft = true;

    void OnMouseOver()
    {
        Scenes.SetActive(true);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Scenes.SetActive(false);
        }
    }
}
