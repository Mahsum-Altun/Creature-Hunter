using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public int takeDamage;
   // public GameObject projectile;

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.TryGetComponent<PlayerDamage>(out PlayerDamage playerDamageComponent))
        {
            playerDamageComponent.TakeDamage(takeDamage);
        }
    }
   // public void Projectile()
   // {
   //     Instantiate(projectile, transform.position, Quaternion.identity);
   // }
}
