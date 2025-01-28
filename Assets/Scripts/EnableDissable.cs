using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDissable : MonoBehaviour
{
    public SpriteRenderer sr;
    public GameObject go;
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
        if (Input.GetMouseButtonDown(0) && go.active)
        {
            sr.enabled = false;
            go.SetActive(false);
            source.PlayOneShot(switchOff);
        }

        if (Input.GetKeyDown(KeyCode.Space) && !go.active)
        {
            sr.enabled = true;
            go.SetActive(true);
            source.PlayOneShot(switchOn);
        }
    }
}
