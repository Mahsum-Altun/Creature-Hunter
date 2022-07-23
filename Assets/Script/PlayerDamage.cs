using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public PlayerHealth playerHealth;

    public Animator playerdie;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        playerHealth.SetMaxHealth(maxHealth);
        playerdie = GameObject.Find("PlayerDid").GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {

        if (currentHealth < 0)
        {
            bool Playerdie = true;
            playerdie.SetBool("PlayerDid", Playerdie);


        }
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        playerHealth.SetHealth(currentHealth);
    }


}
