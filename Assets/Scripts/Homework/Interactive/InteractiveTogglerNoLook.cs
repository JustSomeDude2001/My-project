using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveTogglerNoLook : InteractiveToggler
{
    protected override bool CheckInteraction()
    {
        if (!Input.GetKey(KeyCode.E))
        {
            return false;
        }
        return isInRange;
    }
}
