using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crouch : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private Vector3 crouchingSize;
    private void Update()
    {
        if (Input.GetKey(KeyCode.C))
        {
            target.localScale = crouchingSize;
        }
        else
        {
            target.localScale = new Vector3(1, 1, 1);
        }
    }
}
