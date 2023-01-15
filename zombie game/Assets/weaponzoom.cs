using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class weaponzoom : MonoBehaviour
{

    public Camera fpcamera;
    public float zoomedout = 60f;
    public float zoomedin = 20f;
    public float zoomedoutsensi = 2f;
    public float zoomedinsensi = 0.5f;
    bool zoom = false;
   public  RigidbodyFirstPersonController fps;

    // Start is called before the first frame update

    private void OnDisable()
    {
        zoomout();
    }



    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (zoom == false)
            {
                zoomin();
            }


            else
            {
                zoomout();
            }


        }
    }

    private void zoomout()
    {
        zoom = false;
        fpcamera.fieldOfView = zoomedout;
        fps.mouseLook.XSensitivity = zoomedoutsensi;
        fps.mouseLook.YSensitivity = zoomedoutsensi;
    }

    private void zoomin()
    {
        zoom = true;
        fpcamera.fieldOfView = zoomedin;
        fps.mouseLook.XSensitivity = zoomedinsensi;
        fps.mouseLook.YSensitivity = zoomedinsensi;
    }
}
   



