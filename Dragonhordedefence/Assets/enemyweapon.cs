﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyweapon : MonoBehaviour {

    public Transform firePoint;
    public GameObject bulletPrefab;
    public GameObject hiteffect;

    private float timeBtwShots;
    public float startTimeBtwShots;



    // Update is called once per frame
    private void Update()
    {
        if (timeBtwShots <= 0)
        {

            Instantiate(hiteffect, firePoint.position, firePoint.rotation);
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
                timeBtwShots = startTimeBtwShots;
            
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }
    }
}
