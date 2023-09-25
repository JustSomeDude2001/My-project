using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderingAI : MonoBehaviour
{
    public float speed = 3.0f;
    public float obstacleRange = 5.0f;
    private bool isAlive;
    public float rotationSpeed = 30f;
    
    private void Start()
    {
        isAlive = true;
    }
    void Update()
    {
        if (!isAlive)
        {
            return;
        }
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        if (Physics.SphereCast(ray, 0.75f, out hit))
        {
            if (hit.distance < obstacleRange)
            {
                transform.Rotate(0, Time.deltaTime * rotationSpeed, 0);
            }
            else
            {
                transform.Translate(0, 0, speed * Time.deltaTime);
            }
        }
    }
    
    public void SetAlive(bool alive)
    {
        isAlive = alive;
    }
}