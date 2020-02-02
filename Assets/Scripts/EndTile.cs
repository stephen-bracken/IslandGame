using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTile : MonoBehaviour
{
    public Transform toMove;
    public float moveX = 0f;
    public float moveZ = 25f;
    float cameraSpeed = 0.02f;
    bool moved = false;
    Vector3 direction;

    private Camera cam;
    private RotateCamera rotate;

    void OnTriggerEnter(Collider other)
    {
        Renderer render = GetComponent<Renderer>();
        render.material.color = Color.green;

        other.gameObject.GetComponent<ObjectSelector>().isSelected = false;

        if (!moved)
        {
            toMove.transform.position += new Vector3(moveX, 0f, -moveZ);
            moved = true;


            Vector3 cameraMove = new Vector3(moveX, 0f, moveZ);

            rotate.Point += cameraMove;
            rotate.isMoving = true;
            }
        }

    void Start()
    {
        direction = new Vector3();
        cam = Camera.main;
        rotate = cam.GetComponent<RotateCamera>();
    }

    void Update()
    {
        
        if(moved && cam.transform.position.z < -5f + moveZ)
        {
            direction.x = moveX * cameraSpeed;
            //direction.Y = moveY;
            direction.z = moveZ * cameraSpeed;
            cam.transform.position += direction;
            //rotate.Point += direction;
            //rotate = rotate.Point + Vector3.up;
        }
        else
        {
            rotate.isMoving = false;
        }
    }
}
