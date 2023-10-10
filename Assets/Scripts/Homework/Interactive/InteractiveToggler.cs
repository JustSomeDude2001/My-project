using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InteractiveToggler : Interactive
{
    public Togglable target;

    protected override void OnInteract()
    {
        target.Toggle();
    }
}
