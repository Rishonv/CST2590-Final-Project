using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    [SerializeField] public Transform target;
    [SerializeField][Range(0.1f, 1f)] float smoothSpeed = 0.125f;
    [SerializeField] Vector3 offset;
    private Vector3 velocity = Vector3.zero;
    private Vector3 desiredPosition;
    void LateUpdate()
    {
        desiredPosition = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position,
                                                desiredPosition, ref velocity, smoothSpeed);
    }
}
