using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStop2 : MonoBehaviour
{
    
    public GameObject fist;


    public void ActiveFist()
    {
        fist.GetComponent<Collider>().enabled = true;
    }
    public void DeactiveFist()
    {
        fist.GetComponent<Collider>().enabled = false;
    }

}
