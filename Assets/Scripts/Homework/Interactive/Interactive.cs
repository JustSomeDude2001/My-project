using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactive : MonoBehaviour
{
    protected bool isInRange = false;

    protected abstract void OnInteract();
    protected abstract bool CheckInteraction();

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isInRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isInRange = false;
        }
    }

    private void Update()
    {
        if (CheckInteraction())
        {
            OnInteract();
        }
    }
}
