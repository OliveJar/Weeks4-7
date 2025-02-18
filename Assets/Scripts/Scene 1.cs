using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene1 : MonoBehaviour
{
    private void OnMouseOver()
    {
        //Changes the scene to grasslands if grasslands button is pressed on the map dropdown
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("Grasslands");
        }
    }
}
