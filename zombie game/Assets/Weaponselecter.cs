using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weaponselecter : MonoBehaviour
{

    public int currentweapon = 0;
    // Start is called before the first frame update
    void Start()
    {
        setweaponactive();
    }

    private void setweaponactive()
    {
        int weaponindex = 0;
       

        foreach(Transform weapon in transform)
        {
            if( currentweapon == weaponindex)
            {


                weapon.gameObject.SetActive(true);
            }
            else
            {
                weapon.gameObject.SetActive(false);

            }
            weaponindex++; 

        }
    }

    // Update is called once per frame
    void Update()
    {
        int previousweapon = currentweapon;
        processkeyinput();
        processscrollwheel();


        if(previousweapon!= currentweapon)
        {

            setweaponactive();
        }
    }

    private void processscrollwheel()
    {
        

        if(Input.GetAxis("Mouse ScrollWheel") > 0 )
        {
            if (currentweapon >= transform.childCount - 1)
            {

                currentweapon = 0;
            }

            else
            {
                currentweapon++;
            }

        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            if (currentweapon <= 0)
            {

                 currentweapon =   transform.childCount - 1; 
            }

            else
            {
                currentweapon--;
            }

        }

    }

    private void processkeyinput()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentweapon = 0;

        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentweapon = 1;

        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            currentweapon = 2;

        }
    }
}
