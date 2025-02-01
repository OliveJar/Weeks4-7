using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform player;
    private float t;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += 0.5f * Time.deltaTime;

        if(t>=1)
        {
            t = 0;
        }

        transform.position = new Vector3 (Mathf.Lerp(player.transform.position.x, player.transform.position.x, t), 0, -1);
    }
}
