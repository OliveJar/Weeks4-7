using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public float speed = 10;
    private float velocity;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 20);
    }

    // Update is called once per frame
    void Update()
    {
        velocity = speed * Time.deltaTime;
        transform.position = new Vector2 (transform.position.x - velocity, 0);
    }
}
