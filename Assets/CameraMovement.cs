using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    Vector3 pos = new Vector3(-29f, 7.4f, 15.2f);
    public float speed;
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            pos = transform.position + Vector3.forward/5;

            transform.position = pos ;
        }
        if (Input.GetKey(KeyCode.D))
        {
            pos = transform.position + Vector3.back/5;

            transform.position = pos ;
        }
        if (Input.GetKey(KeyCode.S))
        {
            pos = transform.position + Vector3.left/5;

            transform.position = pos ;
        }
        if (Input.GetKey(KeyCode.W))
        {
            pos = transform.position + Vector3.right/5;

            transform.position = pos ;

        }

    }
}
