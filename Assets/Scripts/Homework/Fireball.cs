using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Fireball : MonoBehaviour
{
    public Rigidbody rigidbody;
    public Vector3 direction;
    public float speed = 3;
    public int damage = 1;
    void Update()
    {
        rigidbody.velocity = direction * speed;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Fireball hit");
            HW_Player player = other.GetComponent<HW_Player>();
            if (player != null)
            {
                player.updateHealth(-damage);
            }

            Destroy(this.gameObject);
        }

        if (other.tag == "World")
        {
            Debug.Log("Fireball hit a wall");
            Destroy(this.gameObject);
        }
    }
}