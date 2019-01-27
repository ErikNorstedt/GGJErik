using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireball : MonoBehaviour
{
    
    public int damage = 20;
    public float speed = 20f;
    Rigidbody2D rb;
    public GameObject hiteffect;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.up * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        enemyScript enemy = collision.GetComponent<enemyScript>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        Instantiate(hiteffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}