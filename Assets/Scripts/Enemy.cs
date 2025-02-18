using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    public float speed = 8;
    private float velocity;

    public Transform bullet;

    private float x;
    private float y;

    void Start()
    {
        transform.position = new Vector2(25, Random.Range(-4, 1));
        bullet = GameObject.FindWithTag("bullet").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        velocity = speed * Time.deltaTime;
        transform.position = new Vector2 (transform.position.x - velocity, 0);

        x = transform.position.x - bullet.transform.position.x;
        y = transform.position.y - bullet.transform.position.y;

        if (x < 9.5 && y < 1 && x > -10 && y >-1 && Input.GetButtonDown("Fire1"))
        {
            print("hit");
            Destroy(gameObject);
            Ifhit.isHit = true;
        }

        Destroy(gameObject, 20);
    }
}
