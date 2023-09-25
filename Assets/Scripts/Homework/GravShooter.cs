using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravShooter : MonoBehaviour
{
    private Camera cam;
    public GameObject projectile;
    public float speed;
    
    void Start()
    {
        cam = Camera.main;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Vector3 point = new Vector3(cam.pixelWidth / 2, cam.pixelHeight / 2, 0);
            Ray ray = cam.ScreenPointToRay(point);
            Vector3 direction = ray.direction.normalized;

            StartCoroutine(Shoot(direction));
        }
    }
    
    private IEnumerator Shoot(Vector3 direction)
    {
        Debug.Log("Enemy shoots");
        GameObject proj = Instantiate(projectile, transform.position, transform.rotation);

        Rigidbody rigidbody = proj.GetComponent<Rigidbody>();

        if (rigidbody != null)
        {
            rigidbody.velocity = direction * speed;
        }
        
        yield return new WaitForSeconds(3);
    }
}