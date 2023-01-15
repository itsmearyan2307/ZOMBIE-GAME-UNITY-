using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{


 [SerializeField] Ammoslot[] ammoslots; 
    // Start is called before the first frame update
    

    [System.Serializable]
    private class Ammoslot
    {

        public Ammotype ammotype;
        public int ammoamount; 


    }


    public int getcurrentammo(Ammotype ammotype)
    {
        return GetAmmoSlot(ammotype).ammoamount; 
    }

    public void reduceammo(Ammotype ammotype)
    {

        GetAmmoSlot(ammotype).ammoamount--;
    }
    public void increaseammo(Ammotype ammotype, int ammoamount)
    {

        GetAmmoSlot(ammotype).ammoamount += ammoamount;
    }


    private Ammoslot GetAmmoSlot(Ammotype ammoType)
    {
        foreach (Ammoslot slot in ammoslots)
        {
            if (slot.ammotype == ammoType)
            {
                return slot;
            }
        }
        return null;
    }
}
