using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapToGrid : MonoBehaviour
{   
    void FixedUpdate()
    {
        var currentPos = transform.position;
        transform.position = new Vector3(Mathf.Round(currentPos.x),
                                     Mathf.Round(currentPos.y),
                                     Mathf.Round(currentPos.z));
    }
}
