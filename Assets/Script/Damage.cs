using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public PlayerHealth playerHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        playerHealth.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){TakeDamage(20);}
    }
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        playerHealth.SetHealth(currentHealth);
    }
}
