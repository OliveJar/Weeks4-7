using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    //Declare variables
    public float speed = 8;
    private float velocity;

    // Start is called before the first frame update
    void Start()
    {
        //Destroy ground after a short while
        Destroy(gameObject, 20);
    }

    // Update is called once per frame
    void Update()
    {
        //Sets ground speed
        velocity = speed * Time.deltaTime;
        //Moves ground across screen at set speed
        transform.position = new Vector2 (transform.position.x - velocity, 0);
    }
}
