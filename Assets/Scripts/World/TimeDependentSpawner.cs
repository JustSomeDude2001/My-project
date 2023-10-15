using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using World;

public abstract class TimeDependentSpawner : GenericSpawner
{
    public abstract float GetChance(float time);
}
