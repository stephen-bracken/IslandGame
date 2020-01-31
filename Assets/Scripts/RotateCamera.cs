using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    private Vector3 point = new Vector3(0.0f, 0.0f, 0.0f);
    private float speed = 100.0f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            transform.RotateAround(point, new Vector3(0.0f, 1.0f, 0.0f), 45);
        }
        if (Input.GetKeyDown("d"))
        {
            transform.RotateAround(point, new Vector3(0.0f, 1.0f, 0.0f), -45);
        }
    }
}
