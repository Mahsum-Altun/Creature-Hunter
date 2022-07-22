using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
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
        //if(Input.GetKeyDown(KeyCode.Space)){TakeDamage(20);}
        if (currentHealth < 0)
      {
        bool Playerdie = true;
        playerdie.SetBool("PlayerDid", Playerdie);
        Debug.Log("aaaa");

      }
    }
   public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        playerHealth.SetHealth(currentHealth);
    }
    private void OnTriggerEnter(Collider other) {
      
      if (other.gameObject.TryGetComponent<PlayerDamage>(out PlayerDamage playerDamageComponent))
      {
        playerDamageComponent.TakeDamage(40);
      }
    }
}
