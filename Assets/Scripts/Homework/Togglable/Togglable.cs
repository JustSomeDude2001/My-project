using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Togglable : MonoBehaviour
{
    protected bool state = false;
    public float interactionCooldown = 2;
    private float _lastInteraction = 0;

    public abstract void SetState(bool targetState);

    public void Toggle()
    {
        if (Time.time - _lastInteraction > interactionCooldown)
        {
            _lastInteraction = Time.time;
            SetState(!state);
        }
    }
}
