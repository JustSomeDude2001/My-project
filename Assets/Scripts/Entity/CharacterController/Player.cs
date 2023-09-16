using System.Collections;
using System.Collections.Generic;
using Entity;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private EntityController inputSource;
    [SerializeField] private float speed = 3.0f;
    [SerializeField] private float sprintSpeed = 6.0f;

    public float GetSpeed()
    {
        if (inputSource.isSprinting)
        {
            return sprintSpeed;
        }
        else
        {
            return speed;
        }
    }
}
