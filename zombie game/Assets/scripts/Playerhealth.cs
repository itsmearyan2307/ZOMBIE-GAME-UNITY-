using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Playerhealth : MonoBehaviour
{

    public TextMeshProUGUI health; 
    public float hitpoints = 100f;
   

   
   



    private void Update()
    {
        displayhealth();
    }

    private void displayhealth()
    {
 
            float currenthealth = hitpoints;
            health.text = currenthealth.ToString();
      

        if (currenthealth <30)
        {

          health.GetComponent<TextMeshProUGUI>().color = Color.red; 
             

        }
    }

    public void damage(float damage)
    {
      
        hitpoints -= damage;

        if (hitpoints <= 0)
        {

           
            GetComponent<Deathhandler>().handledeath();


        }


    }

    public void heal(float healpoints)
    {
        hitpoints += healpoints;


    }
}
