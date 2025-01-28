using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EInteract : MonoBehaviour
{
    public GameObject canvas;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            canvas.SetActive(false);
        }
    }

}
