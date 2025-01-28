using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDissable : MonoBehaviour
{
    public SpriteRenderer sr;
    public GameObject Canvas;
    public AudioClip switchOn;
    public AudioClip switchOff;
    public AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Canvas.active)
        {
            sr.enabled = false;
            Canvas.SetActive(false);
            source.PlayOneShot(switchOff);
        }

        if (Input.GetKeyDown(KeyCode.Space) && !Canvas.active)
        {
            sr.enabled = true;
            Canvas.SetActive(true);
            source.PlayOneShot(switchOn);
        }
    }
}
