using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyhealth : MonoBehaviour
{
    public float hitpoints = 100f;


    bool isdead = false; 

    public bool Isdead()
    {

        return isdead; 
    }



     public void takedamage(float damage)
    {

        BroadcastMessage("ondamagetaken");
        hitpoints = hitpoints- damage;
        if(hitpoints <= 0)
        {

            Die();
        }

    }

    private void Die()
    {
        if (isdead)
        {

            return;
        }
        isdead = true; 
        GetComponent<Animator>().SetTrigger("die");
    }
}
