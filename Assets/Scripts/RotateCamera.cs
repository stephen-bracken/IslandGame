using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    private Vector3 Point = Vector3.zero;
    public Vector3 Axis = Vector3.up;
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown("left"))
        {
            transform.RotateAround(Point, Axis, 45);
        }
        if (Input.GetKeyDown("right"))
        {
            transform.RotateAround(Point, Axis, -45);
        }
    }
}
