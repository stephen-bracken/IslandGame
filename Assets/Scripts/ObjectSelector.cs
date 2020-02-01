using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSelector : MonoBehaviour
{
    public float force = 0.5f;
    public float upForce = 2.5f;
    public bool isSelected = false;
    Rigidbody rb = null;
    Shader shader1;
    Shader shader2;
    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();

        shader1 = Shader.Find("Universal Render Pipeline/Lit");
        shader2 = Shader.Find("Shader Graphs/Glow");
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // LMB
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if (hit.transform != null)
                {
                    PrintName(hit.transform.gameObject);
                    if (rb = hit.transform.GetComponent<Rigidbody>())
                    {
                        rend.material.shader = shader1;
                        rend = hit.transform.GetComponent<Renderer>();
                        rb.isSelected = true;
                    }
                    else
                    {
                        rend.material.shader = shader1;
                        rb.isSelected = false;
                    }
                }
            }
        }

        if (rb.isSelected)
        {
            rend.material.shader = shader2;
            moveBody(rb);
        }
        else
        {
            rend.material.shader = shader1;
        }
    }


    private void PrintName(GameObject go)
    {
        print(go.name);
    }

    
    private void moveBody(Rigidbody rb)
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
    }

    /*
    private void moveBody(Rigidbody rb)
    {
        float moveX = 0.0f;
        float moveY = 0.0f;
        float moveZ = 0.0f;

        // X axis
        if (Input.GetKeyDown("d"))
        {
            moveX += force;
        }
        if (Input.GetKeyDown("a"))
        {
            moveX -= force;
        }

        // Y axis
        if (Input.GetKeyDown("w"))
        {
            moveY += upForce;
        }
        //if (Input.GetKeyDown("s"))
        //{
        //    moveY -= upForce;
        //}

        // Z axis
        if (Input.GetKeyDown("q"))
        {
            moveZ += force;
        }
        if (Input.GetKeyDown("e"))
        {
            moveZ -= force;
        }

        rb.MovePosition(new Vector3 (moveX, moveY, moveZ) + rb.transform.position);
    }*/
}
