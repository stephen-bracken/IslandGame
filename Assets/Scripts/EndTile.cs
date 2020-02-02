using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTile : MonoBehaviour
{
    public Transform toMove;
    public float moveX = 0f;
    public float moveZ = 25f;
    private bool moved = false;

    void OnTriggerEnter(Collider other)
    {
        Renderer render = GetComponent<Renderer>();
        render.material.color = Color.green;

        if (!moved)
        {
            toMove.transform.position += new Vector3(moveX, 0f, moveZ);
            moved = true;
        }
    }
}
