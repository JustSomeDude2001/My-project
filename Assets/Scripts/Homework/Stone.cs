using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        ReactiveTarget target = other.GetComponent<ReactiveTarget>();
        if (target != null)
        {
            target.ReactToHit();
        }

        if (other.gameObject.tag == "Enemy" || other.gameObject.tag == "World")
        {
            Destroy(this.gameObject);
        }
    }
}
