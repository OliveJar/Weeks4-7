using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropDown : MonoBehaviour
{
    public GameObject Scenes;

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseOver()
    {
        Scenes.SetActive(true);
    }
}
