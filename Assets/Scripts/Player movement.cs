using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    //Declare Variables
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
        //If player is holding shift(running) increase the player's velocity
        if (Input.GetKey(KeyCode.LeftShift))
        {
            //changes the rigidbody velocity based off the inputs from a/d or left/right multiplied by a speed factor
            rb.velocity = new Vector2(Input.GetAxis("Horizontal") * 15, rb.velocity.y);
        }
        //If the player is not running then maintain a normal velocity
        else
        {
            //changes the rigidbody velocity based off the inputs from a/d or left/right multiplied by a speed factor
            rb.velocity = new Vector2(Input.GetAxis("Horizontal") * 10, rb.velocity.y);
        }

        //Checks to see if the player is jumping
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W)) && !isFalling)
        {
            //Add an upwards impulse (one time) force on the player's rigidbody when space or w is pressed
            rb.AddForce(Vector2.up * 8, ForceMode2D.Impulse);
        }

        //Calculates the distance between the weapon and the player
        x = Weapon.transform.position.x - transform.position.x;
        y = Weapon.transform.position.y - transform.position.y;

        //Calculates the distance between the ground and the player
        gY = groundY - transform.position.y;

        //Checks to see if the weapon is picked up by the player (player walks over weapon)
        if (x < 1.5 && y < 1.5)
        {
            //Weapon position moves to the player
            Weapon.transform.position = transform.position;
            isCarrying = true;
        }

        //Checks to see if the player is falling
        if (gY > -1.1f)
        {
            isFalling = false;
        }
        else
        {
            isFalling = true;
        }

        //Constrains the player's position so the player does not run off the map
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, minX, maxX), transform.position.y);

        //Checks to see if the player can fire (if the player is holding the weapon)
        if (Input.GetButtonDown("Fire1") && isCarrying)
        {
            //gun animation and sound FX
            isflash = true;
            flash.SetActive(true);
            playerFX.PlayOneShot(pew, 0.1f);
        }
        //Muzzle flash timer
        if (isflash)
        {
            t -= 5 * Time.deltaTime;
        }
        //Muzzle flash timer reset
        if (t <= 0)
        {
            flash.SetActive(false);
            t = 1;
            isflash = false;
        }
    }

}
