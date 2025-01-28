using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public Transform Weapon;
    public Transform holster;
    public bool isCarrying = false;
    private float distanceY;
    private float distanceX;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isCarrying)
        {
            holster.transform.position = transform.position;
        }

        rb.velocity = new Vector2 (Input.GetAxis("Horizontal") * 10, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * 10, ForceMode2D.Impulse);
        }

        distanceY = Weapon.transform.position.y - transform.position.y;
        distanceX = Weapon.transform.position.x - transform.position.x;

        if (distanceX < 2 && distanceY < 2)
        {
            isCarrying = true;
        }
    }
}
