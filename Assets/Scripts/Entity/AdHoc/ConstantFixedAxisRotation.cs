using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantFixedAxisRotation : MonoBehaviour
{
    [SerializeField] private Transform rotationPoint;
    [SerializeField] private Vector3 rotationAxis;
    [SerializeField] private float speed = 1f;

    // Update is called once per frame
    void Update()
    {
        var deltaTime = Time.deltaTime;
        var deltaRotation = deltaTime * speed;
        transform.RotateAround(rotationPoint.position, rotationAxis, deltaRotation);
    }
}
