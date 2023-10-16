using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSInput : MonoBehaviour
{
    public CharacterController characterController;

    public Camera camera;
    
    public float speed = 5;
    private void Update()
    {
        Vector3 direction = new Vector3(0, 0, 0);
        if (Input.GetKey(KeyCode.W))
        {
            direction += camera.transform.forward;
        }

        if (Input.GetKey(KeyCode.A))
        {
            direction += -camera.transform.right;
        }

        if (Input.GetKey(KeyCode.D))
        {
            direction += camera.transform.right;
        }

        if (Input.GetKey(KeyCode.S))
        {
            direction += -camera.transform.forward;
        }

        direction.y = 0;
        direction.Normalize();
        ;
        Vector3 velocity = direction * speed;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            velocity *= 2;
        }

        Vector3 deltaPos = velocity * Time.deltaTime;

        characterController.SimpleMove(deltaPos);
    }
}
