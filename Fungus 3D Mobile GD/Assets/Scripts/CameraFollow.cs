using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Part of this code was used from https://www.youtube.com/watch?v=MFQhpwc6cKE

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    //public float smoothSpeed = 0.125f;
    public Vector3 offset;

    // Update is called after the Update() method.
    void LateUpdate()
    {
        transform.position = target.position + offset;
    }
}