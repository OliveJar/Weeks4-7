using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slider : MonoBehaviour
{
    //Declare Variables
    public float size;
    // Update is called once per frame
    void Update()
    {
        //Makes gun size equal to size variable
        transform.localScale = new Vector3(1, size, size);
    }

    public void AdjustSize(float newSize)
    {
        //makes gun size equal to slider variable
        size = newSize;
    }
}
