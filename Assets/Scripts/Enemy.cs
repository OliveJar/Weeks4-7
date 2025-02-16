using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Enemy : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = -10;

    public TextMeshProUGUI scoreText;
    private int score = 0;

    public Transform bullet;

    private float x;
    private float y;

    void Start()
    {
        transform.position = new Vector2(25, Random.Range(-4, 1));
        rb = GetComponent<Rigidbody>();
        bullet = GameObject.FindWithTag("bullet").GetComponent<Transform>();
        //scoreText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(speed, 0, 0);

        x = transform.position.x - bullet.transform.position.x;
        y = transform.position.y - bullet.transform.position.y;

        if (x < 9.5 && y < 1 && x > -10 && y >-1 && Input.GetButtonDown("Fire1"))
        {
            print("hit");
            Destroy(gameObject);
            score++;
            Debug.Log(score);
        }

        scoreText.text = "Score: " + score;

        Destroy(gameObject, 20);
    }
}
