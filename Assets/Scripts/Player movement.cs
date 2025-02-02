using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public Rigidbody2D rb;

    public Transform Weapon;
    private float y;
    private float x;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * 10, rb.velocity.y);

        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W)))
        {
            rb.AddForce(Vector2.up * 8, ForceMode2D.Impulse);
        }

        x = Weapon.transform.position.x - transform.position.x;
        y = Weapon.transform.position.y - transform.position.y;
        if (x < 1.5 && y < 1.5)
        {
            Weapon.transform.position = transform.position;
        }
    }

}
