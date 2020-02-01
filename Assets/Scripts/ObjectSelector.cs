using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSelector : MonoBehaviour
{
    public float force = 5.0f;
    public bool isSelected = false;
    Rigidbody rb;
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
                        isSelected = true;
                    }
                }
            }
            else
            {
                isSelected = false;
            }
        }

        if (isSelected && rb != null)
        {
            rend.material.shader = shader2;
            moveBody();
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

    private void moveBody()
    {
        // Z axis
        if (Input.GetKeyDown("q"))
        {
            transform.Translate(0, 0, force);
        }
        if (Input.GetKeyDown("e"))
        {
            transform.Translate(0, 0, -force);
        }

        // Y axis
        if (Input.GetKeyDown("w"))
        {
            transform.Translate(0, force, 0);
        }
        if (Input.GetKeyDown("s"))
        {
            transform.Translate(0, -force, 0);
        }

        // X axis
        if (Input.GetKeyDown("d"))
        {
            transform.Translate(force, 0, 0);
        }
        if (Input.GetKeyDown("a"))
        {
            transform.Translate(-force, 0, 0);
        }
    }
}
