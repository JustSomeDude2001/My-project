using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPlatform : MonoBehaviour
{
    public float jumpPower;
        
    private void OnTriggerEnter(Collider other)
    {
        Jump jump;
        if (other.TryGetComponent(out jump))
        {
            jump.TryJump(jumpPower);
        }
    }
}
