using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class Weapons : MonoBehaviour
{

    public Camera fpcamera;
    public float maxrange = 100f;
    public float damage = 30f;
    public GameObject hiteffect;
    public AudioClip gunshot; 
    public ParticleSystem muzzle;
    public Ammo ammoslot;
    AudioSource audioSource;
    public Ammotype ammotype;
    bool canshoot = true;

    public TextMeshProUGUI ammotext;

    public float timebetweenshot = 0.5f;

    private void OnEnable()
    {
        canshoot = true;
    }

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void Update()
    {

        displayammo();
        if (Input.GetMouseButtonDown(0) && canshoot == true   )
        {

            StartCoroutine(Shoot());

        }
    }

    private void displayammo()
    {
        int currentammo = ammoslot.getcurrentammo(ammotype);
          ammotext.text = currentammo.ToString();
    }

    IEnumerator Shoot()
    {
         canshoot = false; 
        if (ammoslot.getcurrentammo(ammotype) > 0 )
        {
            canshoot = false;
            
            playmuzzleflash();
            processraycast();
            playgunshot();
             
            
            ammoslot.reduceammo(ammotype);
        }
        yield return new WaitForSeconds(timebetweenshot);
        canshoot = true;
    }

  void playgunshot()
    {

            audioSource.PlayOneShot(audioSource.clip);
           
        }
       

    private void playmuzzleflash()
    {
        muzzle.Play();
    }

    private void processraycast()
    {
        RaycastHit hit;


        if (Physics.Raycast(fpcamera.transform.position, fpcamera.transform.forward, out hit, maxrange))
        {
            createhit(hit);
            enemyhealth target = hit.transform.GetComponent<enemyhealth>();
            if (target == null)
            {

                return;

            }
            target.takedamage(damage);





        }
        else
        {
            return;
        }
    }

    private void createhit(RaycastHit hit)
    {
       GameObject impact =  Instantiate(hiteffect, hit.point, Quaternion.LookRotation(hit.normal));
        Destroy(impact, .4f);
    }
}


