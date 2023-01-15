using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healthkit : MonoBehaviour
{

    Playerhealth playerhealth;
    public float healpoints = 15f;
    


    private void OnEnable()
    {
        playerhealth = GetComponent<Playerhealth>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Playerhealth>().heal(healpoints);
            Destroy(gameObject);


        }
    }
}
