using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStop1 : MonoBehaviour
{
    private Animator enemyAttack;

    private void Start()
    {
        enemyAttack = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == ("EnemyStop1"))
        {
            bool EnemyAttack = true;
            enemyAttack.SetBool("Attack", EnemyAttack);
        }

    }

}
