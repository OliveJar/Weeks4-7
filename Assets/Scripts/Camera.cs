using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private Vector3 pos;
    public float maxX;
    public float minX;
    private Vector3 offset = new Vector3(0f, 5f, -10f);
    private float smoothTime = 0.25f;
    private Vector3 velocity = Vector3.zero;

    [SerializeField] private Transform target;

    private void Update()
    {
        Vector3 targetPosition = target.position + offset;
        pos = new Vector3 (Mathf.Clamp(transform.position.x, minX, maxX), transform.position.y, transform.position.z);
        transform.position = Vector3.SmoothDamp(pos, targetPosition, ref velocity, smoothTime);
    }
}
