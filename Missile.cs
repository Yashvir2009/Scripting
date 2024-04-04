using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Missile : MonoBehaviour
{
    public float speed = 10f;

    void Start()
    {
        // Destroy the projectile after 3 seconds
        Destroy(gameObject, 3);
    }

    void Update()
    {
        // Move the fireball forward
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    void OnTriggerEnter(Collider other)
    {
        // Destroy the enemy
        Destroy(other.gameObject);
            
        // Destroy the projectile
        Destroy(gameObject);
        
    }
}


