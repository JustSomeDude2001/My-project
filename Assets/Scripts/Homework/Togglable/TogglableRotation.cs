using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TogglableRotation : Togglable
{
    public Vector3 rotationAcceleration = new Vector3(0, 30, 0);
    public Vector3 targetRotationSpeedOn = new Vector3(0, 100, 0);
    public Vector3 rotationDeceleration = new Vector3(0, -20, 0);
    public Vector3 targetRotationSpeedOff = new Vector3(0, 0, 0);

    public Vector3 currentRotation = new Vector3(0, 0, 0);
    
    public override void SetState(bool targetState)
    {
        Debug.Log("Changed state to " + targetState);
        state = targetState;
    }

    private void Update()
    {
        float deltaTime = Time.deltaTime;
        if (state)
        {
            if (currentRotation.x < targetRotationSpeedOn.x)
            {
                currentRotation.x += rotationAcceleration.x * deltaTime;
            }
            if (currentRotation.y < targetRotationSpeedOn.y)
            {
                currentRotation.y += rotationAcceleration.y * deltaTime;
            }
            if (currentRotation.z < targetRotationSpeedOn.z)
            {
                currentRotation.z += rotationAcceleration.z * deltaTime;
            }
        }
        else
        {
            if (currentRotation.x > targetRotationSpeedOff.x)
            {
                currentRotation.x += rotationDeceleration.x * deltaTime;
            }
            if (currentRotation.y > targetRotationSpeedOff.y)
            {
                currentRotation.y += rotationDeceleration.y * deltaTime;
            }
            if (currentRotation.z > targetRotationSpeedOff.z)
            {
                currentRotation.z += rotationDeceleration.z * deltaTime;
            }
            
        }
        transform.Rotate(currentRotation * deltaTime);
    }
}
