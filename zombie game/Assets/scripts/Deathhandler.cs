using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Deathhandler : MonoBehaviour
{
   

    public Canvas gameover;
    // Start is called before the first frame update
    void Start()
    {
        gameover.enabled = false;
    }



    public void handledeath()
    {

        gameover.enabled = true;
        Time.timeScale = 0;

        FindObjectOfType<Weaponselecter>().enabled = false; 
        GetComponent<RigidbodyFirstPersonController>().mouseLook.lockCursor = false;
         
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
       
    }
    // Update is called once per frame
   
}
