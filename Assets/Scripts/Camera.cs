using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    //Declare variables
    private Vector3 pos;
    public float maxX;
    public float minX;

    //player position offset
    private Vector3 offset = new Vector3(0f, 5f, -10f);
    private float smoothTime = 0.25f;
    private Vector3 velocity = Vector3.zero;

    //Private but visible in the inspector
    [SerializeField] private Transform target;

    private void Update()
    {
        //Adds the offset to the player's position
        Vector3 targetPosition = target.position + offset;

        //Calculates new position with a constraint so the camera cannot see outside the map
        pos = new Vector3 (Mathf.Clamp(transform.position.x, minX, maxX), transform.position.y, transform.position.z);

        //Applies new position to camera to follow the player and adds a smooth transition
        transform.position = Vector3.SmoothDamp(pos, targetPosition, ref velocity, smoothTime);
    }
}
