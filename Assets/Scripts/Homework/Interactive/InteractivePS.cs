using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractivePS : Interactive
{
    public ParticleSystem particleSystem;

    private void Start()
    {
        particleSystem.Stop();
    }

    protected override void OnInteract()
    {
        if (!particleSystem.isPlaying)
        {
            particleSystem.Play();
        }
    }

    protected override bool CheckInteraction()
    {
        return isInRange;
    }
}

