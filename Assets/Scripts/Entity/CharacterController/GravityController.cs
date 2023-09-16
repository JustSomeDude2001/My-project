using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityController : MonoBehaviour
{
    [SerializeField] private CharacterController characterController;
    [SerializeField] private float gravityValue = -9.81f;
    void Update()
    {
        Vector3 playerVelocity = characterController.velocity;
        
        playerVelocity.y += gravityValue * Time.deltaTime;
        
        if (characterController.isGrounded && playerVelocity.y < 0)
        {
            playerVelocity.y = 0;
        }

        characterController.Move(playerVelocity * Time.deltaTime);
    }
}
