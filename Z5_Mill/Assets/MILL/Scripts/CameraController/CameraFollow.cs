﻿
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Focus Point
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    void LateUpdate(){

        transform.position = target.position + offset;
        //transform.LookAt(target);
    }
}
