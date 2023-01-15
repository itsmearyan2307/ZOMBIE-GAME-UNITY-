using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Enemyai : MonoBehaviour
{

    public float range = 5f;
    bool catchable = true;
    float targetdistance = Mathf.Infinity;
    NavMeshAgent navmeshagent;
     Transform target;
    public GameObject player; 
    enemyhealth health; 

    public float turnspeed = 5f; 
    void Start()
    {

        target = FindObjectOfType<Playerhealth>().transform ;
        
        navmeshagent = GetComponent<NavMeshAgent>();
        health = GetComponent<enemyhealth>();
        
    }


    void Update()
    {
        if (health.Isdead())
        {
            enabled = false;
            navmeshagent.enabled = false; 


        }
        targetdistance = Vector3.Distance(target.position, transform.position);

        if (catchable)
        {
            EngageTarget();
        }
      
    }

    public void ondamagetaken()
    {
        catchable = true;



    }

       
    private void EngageTarget()
    {

        

       
        if (targetdistance >= navmeshagent.stoppingDistance)
        {
            if (navmeshagent.enabled)
            {
                navmeshagent.SetDestination(target.position);
                ChaseTarget();
            }
        }

        if (targetdistance <= navmeshagent.stoppingDistance )
        {
            AttackTarget();
        }
    }

    private void ChaseTarget()
    {

        
        GetComponent<Animator>().SetBool("attack", false);
        GetComponent<Animator>().SetTrigger("move");
        if (navmeshagent.enabled)
        {
            navmeshagent.SetDestination(target.position);
        }
        
    }

    private void AttackTarget()
    {

        GetComponent<Animator>().SetBool("attack", true);
        
    }

   
}


