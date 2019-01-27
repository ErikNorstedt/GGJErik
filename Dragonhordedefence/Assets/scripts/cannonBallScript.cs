using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonBallScript : MonoBehaviour {

    public int damage = 20;
    public float speed = 10f;
    Rigidbody2D rb;
    public GameObject hiteffect;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.up * speed;
    }


    // Update is called once per frame
    void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Tower"))
        {
            PlayerHealth player = collision.GetComponent<PlayerHealth>();
            if (player != null)
            {
                player.TakeDamage(damage);
            }
            Instantiate(hiteffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
