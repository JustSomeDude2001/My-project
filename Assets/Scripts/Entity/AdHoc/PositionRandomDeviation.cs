using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class PositionRandomDeviation : MonoBehaviour
{
    private static Random _random;

    public float xDeviation;
    public float yDeviation;
    public float zDeviation;
    
    private void Start()
    {
        _random ??= new Random();

        var currentPos = transform.position;

        currentPos.x += (float)(_random.NextDouble()) * xDeviation;
        currentPos.y += (float)(_random.NextDouble()) * yDeviation;
        currentPos.z += (float)(_random.NextDouble()) * zDeviation;

        transform.position = currentPos;
    }
}
