using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootsAtPlayer : MonoBehaviour
{
    public GameObject player;
    public GameObject projectile;
    public float cooldown;

    private float _untilNextShot;
    
    void Start()
    {
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }

        _untilNextShot = cooldown;
    }

    private void Update()
    {
        _untilNextShot -= Time.deltaTime;
        if (_untilNextShot > 0)
        {
            return;
        }

        _untilNextShot = cooldown;
        StartCoroutine(Shoot());
    }

    private IEnumerator Shoot()
    {
        Debug.Log("Enemy shoots");
        GameObject proj = Instantiate(projectile, transform.position, transform.rotation);

        Vector3 direction = (player.transform.position - transform.position).normalized;

        Fireball fireball = proj.GetComponent<Fireball>();

        if (fireball != null)
        {
            fireball.direction = direction;
        }
        
        yield return new WaitForSeconds(3);
    }
}
