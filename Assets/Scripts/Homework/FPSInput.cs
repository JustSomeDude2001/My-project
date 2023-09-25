using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSInput : MonoBehaviour
{
    public float speed = 5;
    private void Update()
    {
        Vector3 direction = new Vector3(0, 0, 0);
        if (Input.GetKey(KeyCode.W))
        {
            direction += transform.forward;
        }

        if (Input.GetKey(KeyCode.A))
        {
            direction += -transform.right;
        }

        if (Input.GetKey(KeyCode.D))
        {
            direction += transform.right;
        }

        if (Input.GetKey(KeyCode.S))
        {
            direction += -transform.forward;
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

        transform.position += deltaPos;
    }
}
