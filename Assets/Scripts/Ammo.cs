using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
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
        x = ammo.transform.position.x - transform.position.x;
        y = ammo.transform.position.y - transform.position.y;

        if (x < 1.5 && y < 1.5 && !ammoSound.isPlaying)
        {
            ammoSound.PlayOneShot(ammoclip);
        }
        if (ammoSound.isPlaying)
        {
            T -= time * Time.deltaTime;
        }
        if (T <= 0)
        {
            ammo.SetActive(false);
        }
    }
}