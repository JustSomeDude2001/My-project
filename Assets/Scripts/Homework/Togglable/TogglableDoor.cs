using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TogglableDoor : Togglable
{
    public Renderer renderer;
    public Collider collider;
    
    public override void SetState(bool targetState)
    {
        state = targetState;
        renderer.enabled = state;
        collider.enabled = state;
    }
}
