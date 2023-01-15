using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlighthandler : MonoBehaviour
{




    public Light mylight;

    public float decreaseintensity = 0.1f;
        public float decreaseangle = 1f;
    float minangle = 40f; 
    // Start is called before the first frame update
    void Start()
    {
        mylight = GetComponent < Light>();
    }

    // Update is called once per frame
    void Update()
    {
        decreaselight();

        decreaseangel();

    }

    private void decreaselight()
    {
        mylight.intensity -= decreaseintensity*Time.deltaTime;
    }

    private void decreaseangel()
    {
        if (mylight.spotAngle <= minangle)
        {

            return;
        }
        else
        {
            mylight.spotAngle -= decreaseangle*Time.deltaTime;
        }
    }


    public void increaselight(float lightvalue) 
    {

        mylight.intensity += lightvalue;
    
    
    }

    public void restoreangle(float angle)
    {

        mylight.spotAngle = angle; 


    }
}
