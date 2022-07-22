using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStop2 : MonoBehaviour
{
       private Animator enemyAttack;
       public GameObject fist;

  private void Start() {
    enemyAttack = GetComponent<Animator>();
   }
      private void OnTriggerEnter(Collider other) {
      

      if(other.gameObject.tag == ("EnemyStop2"))
      {
        bool EnemyAttack = true;
        enemyAttack.SetBool("Attack", EnemyAttack);
        //rb.constraints = RigidbodyConstraints.FreezePosition;
     
      }

      
    }
    public void ActiveFist()
    {
      fist.GetComponent<Collider>().enabled = true;   
    }
    public void DeactiveFist()
    {
       fist.GetComponent<Collider>().enabled = false;
    }
    
}
