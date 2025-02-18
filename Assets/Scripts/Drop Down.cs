using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropDown : MonoBehaviour
{
    //Declare variables
    public GameObject Scenes;
    private bool IsMouseOver = false;
    private bool IsMouseLeft = true;

    //Makes scenes viewable when mouse is over map
    void OnMouseOver()
    {
        Scenes.SetActive(true);
    }
    void Update()
    {
        //if esc is pressed hide the scenes
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Scenes.SetActive(false);
        }
    }
}
