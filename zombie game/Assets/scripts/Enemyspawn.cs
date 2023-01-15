using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyspawn : MonoBehaviour
{

    public GameObject enemyprefab;
     public int xpos;
   public  int zpos;
    public int enemycount; 

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Enemygenerate());
    }

    
     IEnumerator Enemygenerate()
    {
       
        {
            while (enemycount <= 5) 
            {
                xpos = Random.Range(1, 30);
                zpos = Random.Range(1,50);
                Instantiate(enemyprefab, new Vector3(xpos, 0, zpos), Quaternion.identity);
                yield return new WaitForSeconds(1f);
                enemycount += 1; 



            }


        }
    }
}
