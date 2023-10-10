using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveTogglerTrigger : InteractiveToggler
{

    // Update is called once per frame
    protected override bool CheckInteraction()
    {
        return isInRange;
    }

}
