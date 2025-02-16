using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Transform enemy;

    public static bool hit;

    private float x;
    private float y;

    // Start is called before the first frame update
    void Start()
    {
        enemy = GameObject.FindWithTag("Enemy").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        x = enemy.transform.position.x - transform.position.x;
        y = enemy.transform.position.y - transform.position.y;

        if (x < 14 && y < 1 && x >-14 && y >-1 && Input.GetButtonDown("Fire1"))
        {
            print("within range");
            hit = true;
        }
    }
}
