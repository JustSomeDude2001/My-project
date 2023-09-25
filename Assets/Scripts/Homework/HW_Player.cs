using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class HW_Player : MonoBehaviour
{
    [SerializeField] private int health;

    public void updateHealth(int delta)
    {
        health += delta;
        Debug.Log("Health changed to " + health);
        if (health <= 0)
        {
            Debug.Log("player died");
        }
    }
}
