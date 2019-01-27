using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour
{

    Image healthBar;
    float maxHealth = 160f;
    public static float Health;

    void Start()
    {
        healthBar = GetComponent<Image>();
        Health = maxHealth;
    }

    void Update()
    {
        healthBar.fillAmount = Health / maxHealth;
    }
}