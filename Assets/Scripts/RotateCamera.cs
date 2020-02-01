﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    private Vector3 Point = Vector3.zero;
    private Vector3 Axis = Vector3.up;
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown("a"))
        {
            transform.RotateAround(Point, Axis, 45);
        }
        if (Input.GetKeyDown("d"))
        {
            transform.RotateAround(Point, Axis, -45);
        }
    }
}
