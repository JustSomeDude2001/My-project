using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = System.Random;

public class HW_PlayerRandomizer : MonoBehaviour
{
    public HW_Player player;
    public float cooldown = 2f;
    private float _cooldownCounter;
    private static Random _random;

    private void Start()
    {
        _cooldownCounter = cooldown;
        if (_random == null)
        {
            _random = new Random();
        }
    }

    // Update is called once per frame
    void Update()
    {
        _cooldownCounter -= Time.deltaTime;
        if (_cooldownCounter <= 0)
        {
            _cooldownCounter = cooldown;
            Vector3 newPos = new Vector3();
            newPos.x = (float) _random.NextDouble();
            newPos.y = (float) _random.NextDouble();
            newPos.z = (float) _random.NextDouble();
            
            player.position = newPos;
            player.updateHealth(-(_random.Next() % 100));
        }
    }
}
