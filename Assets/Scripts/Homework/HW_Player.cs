using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class HW_Player : MonoBehaviour
{
    public Vector3 position;
    private int _health;

    public void updateHealth(int delta)
    {
        _health += delta;
        if (_health <= 0)
        {
            Debug.Log("player died");
        }
    }
}
