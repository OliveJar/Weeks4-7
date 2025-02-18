using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene2 : MonoBehaviour
{
    private void OnMouseOver()
    {
        //Changes the scene to dessert if dessert button is pressed on the map dropdown
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("Dessert");
        }
    }
}
