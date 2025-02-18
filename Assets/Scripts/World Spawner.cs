using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldSpawner : MonoBehaviour
{
    //Declare variables
    public GameObject ground;
    public GameObject enemy;
    public Transform spawnLocation;
    public float timer;
    private float t = 50;

    // Update is called once per frame
    void Update()
    {
        //Timer
        t -= timer * Time.deltaTime;

        //When timer hits 0 instantiate new ground prefab at spawn location
        if (t <= 0)
        {
            t = 50;
            Instantiate (ground, spawnLocation);
            Instantiate (enemy, spawnLocation);
        }
    }
}
