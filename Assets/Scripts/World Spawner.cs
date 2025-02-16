using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldSpawner : MonoBehaviour
{
    public GameObject ground;
    public Transform spawnLocation;
    public float timer;
    private float t = 50;

    // Update is called once per frame
    void Update()
    {
        t -= timer * Time.deltaTime;

        if (t <= 0)
        {
            t = 50;
            Instantiate (ground, spawnLocation);
        }
    }
}
