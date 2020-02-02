using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSelector : MonoBehaviour
{
    Rigidbody rb;
    Renderer rend;

    GameObject selected;
    public bool isSelected = false;

    Shader shader1;
    Shader shader2;

    void Start()
    {
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
                if (hit.transform != null && hit.transform.gameObject.tag == "Movable")
                {
                    reset();

                    PrintName(hit.transform.gameObject);

                    if (rb = hit.transform.GetComponent<Rigidbody>())
                    {
                        isSelected = true;
                        selected = hit.transform.gameObject;
                        rend = selected.GetComponent<Renderer>();
                    }
                }
            }
        }

        if (selected && isSelected)
        {
            rend.material.shader = shader2;
            MoveBody MoveBody = selected.GetComponent<MoveBody>();
            MoveBody.enabled = true;
        }
        else if (selected)
        {
            rend.material.shader = shader1;
            MoveBody MoveBody = selected.GetComponent<MoveBody>();
            MoveBody.enabled = false;
            isSelected = false;
        }
        else
        {
            rend.material.shader = shader1;
            selected = null;
            rend = null;
        }
    }

    public void reset()
    {
        if (selected)
        {
            rend.material.shader = shader1;
            MoveBody MoveBody = selected.GetComponent<MoveBody>();
            MoveBody.enabled = false;
        }

        isSelected = false;
        selected = null;
        rend = null;
    }

    private void PrintName(GameObject go)
    {
        print(go.name);
    }

}
