using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour {

    public int Health = 100;
    public GameObject choosenDeathClip;

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
