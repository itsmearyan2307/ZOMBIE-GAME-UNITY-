using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playaudio : MonoBehaviour
{
    AudioSource audioSource; 
    public AudioClip shot; 
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Alpha5))
        {
            proccessound();
        }
    }

    private void proccessound()
    {
        audioSource.PlayOneShot(shot);
    }
}
