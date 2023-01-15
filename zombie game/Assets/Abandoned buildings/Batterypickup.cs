using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Batterypickup : MonoBehaviour
{
    // Start is called before the first frame update
    public float addintensity = 1f;

    public float restoredangle = 90f;


    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponentInChildren<Flashlighthandler>().increaselight(addintensity);
                 other.gameObject.GetComponentInChildren<Flashlighthandler>().restoreangle(restoredangle);
            Destroy(gameObject);


        }
    }

}
