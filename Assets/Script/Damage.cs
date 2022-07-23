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


    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        playerHealth.SetHealth(currentHealth);
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.TryGetComponent<PlayerDamage>(out PlayerDamage playerDamageComponent))
        {
            playerDamageComponent.TakeDamage(40);
        }
    }
}
