using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    Vector3 offset;

    private void Start()
    {
        offset = transform.position; // initial position of the camera
    }
    private void LateUpdate()
    {
        transform.position = player.transform.position + offset; // as the player moves, so does the camera
    }
}
