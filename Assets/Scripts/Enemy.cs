using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    //Declare variables
    public float speed = 8;
    private float velocity;

    public Transform bullet;

    private float x;
    private float y;

    void Start()
    {
        //Spawn at a random position
        transform.position = new Vector2(25, Random.Range(-4, 1));

        //Find bullet trajectory position
        bullet = GameObject.FindWithTag("bullet").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //Set enemy speed
        velocity = speed * Time.deltaTime;

        //Move the enemy across the screen acording to speed
        transform.position = new Vector2 (transform.position.x - velocity, 0);

        //Calculates the distance between enemy and bullet
        x = transform.position.x - bullet.transform.position.x;
        y = transform.position.y - bullet.transform.position.y;

        //Checks to see if enemy is within range of bullet trajectory and if weapon is fired
        if (x < 9.5 && y < 1 && x > -10 && y >-1 && Input.GetButtonDown("Fire1"))
        {
            //Destroy enemy and tell score script to update score
            print("hit");
            Destroy(gameObject);
            Score.isHit = true;
        }
        //if enemy is not hit destroy after some time
        Destroy(gameObject, 20);
    }
}
