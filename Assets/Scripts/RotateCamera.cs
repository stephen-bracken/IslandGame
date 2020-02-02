using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public Vector3 Point = Vector3.zero;
    public bool isMoving = false;
    private Vector3 Axis = Vector3.up;
    // Update is called once per frame
    void Update()
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
