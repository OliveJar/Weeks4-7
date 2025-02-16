using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slider : MonoBehaviour
{
    public float size;
    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(1, size, size);
    }

    public void AdjustSize(float newSize)
    {
        size = newSize;
    }
}
