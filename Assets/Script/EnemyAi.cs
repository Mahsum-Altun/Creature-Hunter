using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyAi : MonoBehaviour
{
   public float speed;
   Rigidbody rb;
   public Transform target;
   Vector3 moveDirection;
   public Animator enemyAttack;
   

   private void Awake() 
   {
      rb = GetComponent<Rigidbody>(); 
   }
   private void Start() {
    // target = GameObject.transform;
   }
   private void Update() {
    if(target){
        Vector3 direction = (target.position - transform.position).normalized;
        //float angle = Mathf.Atan2(direction.y, direction.z) * Mathf.Rad2Deg;
        //transform.Rotate(0, angle, 0);
        moveDirection = direction;
    }
   }
   private void FixedUpdate() {
    if (target)
    {
        rb.velocity = new Vector3(moveDirection.x, moveDirection.y, moveDirection.z) * speed;
    }
   }
   private void OnTriggerEnter(Collider other) {
    if(other.gameObject.tag == ("Enemy"))
    {
       bool EnemyAttack = true;
      enemyAttack.SetBool("Attack", EnemyAttack);
    }
   }
}
