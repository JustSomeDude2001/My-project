using System.Collections;
using System.Collections.Generic;
using Entity;
using UnityEngine;

public class AlternativeMovement : MonoBehaviour
{
    public CharacterController characterController;
    public Player player;
    public EntityController entityController;
    
    // Update is called once per frame
    void Update()
    {
        float deltaTime = Time.deltaTime;
        Vector3 velocity = entityController.GetWorldMovementDirection() * player.GetSpeed() * deltaTime;

        characterController.Move(velocity);
    }
}
