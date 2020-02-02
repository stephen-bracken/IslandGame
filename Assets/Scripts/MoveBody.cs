using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBody : MonoBehaviour
{
    public float force = 1f;
    public float upForce = 2.5f;
    Rigidbody rb;

    Shader shader1;
    Shader shader2;
    Renderer rend;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //rend = GetComponent<Renderer>();

        //shader1 = Shader.Find("Universal Render Pipeline/Lit");
        //shader2 = Shader.Find("Shader Graphs/Glow");
    }

    private void Update()
    {
        // Z axis
        if (Input.GetKeyDown("q"))
        {
            rb.transform.Translate(0, 0, force);
        }
        if (Input.GetKeyDown("e"))
        {
            rb.transform.Translate(0, 0, -force);
        }

        // Y axis
        if (Input.GetKeyDown("w"))
        {
            rb.transform.Translate(0, upForce, 0);
        }
        //if (Input.GetKeyDown("s"))
        //{
        //    rb.transform.Translate(0, -force, 0);
        //}

        // X axis
        if (Input.GetKeyDown("d"))
        {
            rb.transform.Translate(force, 0, 0);
        }
        if (Input.GetKeyDown("a"))
        {
            rb.transform.Translate(-force, 0, 0);
        }

        Vector3 pos = rb.transform.position;
        pos = new Vector3(Mathf.Round(pos.x) + 0.5f, pos.y, Mathf.Round(pos.z) + 0.5f);

    }
}
