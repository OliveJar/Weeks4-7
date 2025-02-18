using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    //Declare variables
    public GameObject ammo;
    public AudioClip ammoclip;
    public AudioSource ammoSound;
    public float time = 400;
    private float T = 300;
    private float x;
    private float y;

    // Update is called once per frame
    void Update()
    {
        //Calculates distance from ammo box to player
        x = ammo.transform.position.x - transform.position.x;
        y = ammo.transform.position.y - transform.position.y;

        //Checks to see if player has picked up ammo (walked over it)
        if (x < 1.5 && y < 1.5 && !ammoSound.isPlaying)
        {
            //Play ammo sound if not playing already
            ammoSound.PlayOneShot(ammoclip);
        }
        //When ammo sound plays
        if (ammoSound.isPlaying)
        {
            //Ammo sound stop delay
            T -= time * Time.deltaTime;
        }
        //Stop playing ammo sound after delay
        if (T <= 0)
        {
            ammo.SetActive(false);
        }
    }
}