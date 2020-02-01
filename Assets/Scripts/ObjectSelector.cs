using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSelector : MonoBehaviour
{
    public float force = 5.0f;

    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0)) // LMB
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if (hit.transform != null)
                {
                    Rigidbody rb;
                    PrintName(hit.transform.gameObject);
                    if (rb = hit.transform.GetComponent<Rigidbody>())
                    {
                        moveBody(rb);
                    }
                }
            }
        }
    }

    
    private void PrintName(GameObject go)
    {
        print(go.name);
    }

    private void moveBody(Rigidbody rig)
    {
        // Z axis
        if (Input.GetKeyDown("q"))
        {
            rig.AddForce(transform.forward * force);
        }
        if (Input.GetKeyDown("a"))
        {

        }

        // Y axis
        if (Input.GetKeyDown("w"))
        {

        }
        if (Input.GetKeyDown("s"))
        {

        }

        // X axis
        if (Input.GetKeyDown("d"))
        {

        }
        if (Input.GetKeyDown("e"))
        {

        }
    }
}
