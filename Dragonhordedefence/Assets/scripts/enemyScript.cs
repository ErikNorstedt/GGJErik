﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour {

    public float speed = 1f;
    public int Health = 100;
    public GameObject choosenDeathClip;
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * -speed;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Stop"))
        {
            speed = 0f;
            rb.velocity = Vector2.zero;
        }
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;

        if (Health <= 0)
        {
            Die();
        }
    }
    void Die ()
    {
        Instantiate(choosenDeathClip, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
