using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammopickup : MonoBehaviour

    
{
   
  
    public int ammoammount = 5;

    public Ammotype ammotype;




private void OnCollisionEnter(Collision other)
{
        if(other.gameObject.tag  == "Player")
        {
            FindObjectOfType<Ammo>().increaseammo(ammotype, ammoammount);
            Destroy(gameObject);
            


        }
    }
}
