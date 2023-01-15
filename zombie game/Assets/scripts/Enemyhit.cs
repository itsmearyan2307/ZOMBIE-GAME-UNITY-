using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyhit : MonoBehaviour
{

  Playerhealth target;


    public float damage = 30f; 
    // Start is called before the first frame update
    void Start()
    {
        target = FindObjectOfType<Playerhealth>();
    }

    // Update is called once per frame
    

    public void onattack()
    {
       if(target == null)
        {

            return;
        }
       else
        {

            target.damage(damage);
            target.GetComponent<Damagereceive>().receivedamage();
        }
    }
}
