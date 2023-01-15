using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damagereceive : MonoBehaviour
{

    public Canvas damage;
    public float delaytime = 0.9f;
    // Start is called before the first frame update
    void Start()
    {
        damage.enabled = false; 
    }

    // Update is called once per frame
    
    public void receivedamage()
    {
    StartCoroutine(splatter());

    }

    IEnumerator splatter()
    {
        damage.enabled = true;
        yield return new WaitForSeconds(delaytime);
        damage.enabled = false; 
    }
}
