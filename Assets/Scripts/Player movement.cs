using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    [Header("Gun")]
    public GameObject flash;
    private bool isflash;
    private float t;
    public AudioClip pew;
    public AudioSource playerFX;

    [Header("Player Movement")]
    public Rigidbody2D rb;
    public Transform Weapon;
    private bool isCarrying = false;
    public float groundY = -5;
    private float gY;
    private bool isFalling;
    private float y;
    private float x;

    public float minX = -27;
    public float maxX = 27;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            rb.velocity = new Vector2(Input.GetAxis("Horizontal") * 15, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(Input.GetAxis("Horizontal") * 10, rb.velocity.y);
        }

        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W)) && !isFalling)
        {
            rb.AddForce(Vector2.up * 8, ForceMode2D.Impulse);
        }

        x = Weapon.transform.position.x - transform.position.x;
        y = Weapon.transform.position.y - transform.position.y;

        gY = groundY - transform.position.y;

        if (x < 1.5 && y < 1.5)
        {
            Weapon.transform.position = transform.position;
            isCarrying = true;
        }

        if (gY > -1.1f)
        {
            isFalling = false;
        }
        else
        {
            isFalling = true;
        }

        transform.position = new Vector2(Mathf.Clamp(transform.position.x, minX, maxX), transform.position.y);

        if (Input.GetButtonDown("Fire1") && isCarrying)
        {
            isflash = true;
            flash.SetActive(true);
            playerFX.PlayOneShot(pew, 0.1f);
        }
        if (isflash)
        {
            t -= 5 * Time.deltaTime;
        }
        if (t <= 0)
        {
            flash.SetActive(false);
            t = 1;
            isflash = false;
        }
    }

}
