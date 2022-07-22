using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyAi : MonoBehaviour
{
   public float speed;
   Rigidbody rb;
   Transform target;
   Vector3 moveDirection;
   

   private void Awake() 
   {
      rb = GetComponent<Rigidbody>();
      if(gameObject.tag == "Warrok1"){ 
      target = GameObject.Find("Enemy1").GetComponent<Transform>();
      }
      else if (gameObject.tag == "Warrok2")
      {
        target = GameObject.Find("Enemy1 (1)").GetComponent<Transform>();
      }
      else if (gameObject.tag == "Warrok3")
      {
        target = GameObject.Find("Enemy1 (2)").GetComponent<Transform>();
      }
      else if (gameObject.tag == "Zombie1")
      {
        target = GameObject.Find("Enemy2").GetComponent<Transform>();
      }
      else if (gameObject.tag == "Zombie2")
      {
        target = GameObject.Find("Enemy2 (1)").GetComponent<Transform>();
      }
      else if (gameObject.tag == "Zombie3")
      {
        target = GameObject.Find("Enemy2 (2)").GetComponent<Transform>();
      }
      else if (gameObject.tag == "Zombie4")
      {
        target = GameObject.Find("Enemy2 (3)").GetComponent<Transform>();
      }
   }
   private void Start() {
    
   }
   private void Update() {
    if(target){
        Vector3 direction = (target.position - transform.position).normalized;
        moveDirection = direction;
    }
   }
   private void FixedUpdate() {
    if (target)
    {
        rb.velocity = new Vector3(moveDirection.x, moveDirection.y, moveDirection.z) * speed;
        if (moveDirection == Vector3.zero)
    {
       return;
    }
     Quaternion targetRotation = Quaternion.LookRotation(moveDirection);
     targetRotation = Quaternion.RotateTowards(transform.rotation,targetRotation,180 * Time.fixedDeltaTime);
     rb.MovePosition(rb.position + moveDirection * speed * Time.fixedDeltaTime);
     rb.MoveRotation(targetRotation);
    }
   }
   private void OnTriggerEnter(Collider other) {
      

      if(other.gameObject.tag == ("EnemyStop2") && gameObject.tag == "Zombie1" || other.gameObject.tag == ("EnemyStop2") && gameObject.tag == "Zombie2" || other.gameObject.tag == ("EnemyStop2") && gameObject.tag == "Zombie3" || other.gameObject.tag == ("EnemyStop2") && gameObject.tag == "Zombie4")
      {
        //rb.constraints = RigidbodyConstraints.FreezePosition;
        speed = 0;
     
      }
     
      else if(other.gameObject.tag == ("EnemyStop1") && gameObject.tag == "Warrok1" || other.gameObject.tag == ("EnemyStop1") && gameObject.tag == "Warrok2" || other.gameObject.tag == ("EnemyStop1") && gameObject.tag == "Warrok3")
      {
        speed = 0;
      }
   }
   
  
   
}
