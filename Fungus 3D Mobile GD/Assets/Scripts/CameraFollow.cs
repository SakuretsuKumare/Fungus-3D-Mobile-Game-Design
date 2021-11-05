using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Part of this code was used from https://www.youtube.com/watch?v=MFQhpwc6cKE

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    // Update is called after the Update() method. Has the camera follow the position of the player with an offset.
    void LateUpdate()
    {
        transform.position = target.position + offset;
    }
}