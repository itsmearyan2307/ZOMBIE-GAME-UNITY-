using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneloader : MonoBehaviour
{
    // Start is called before the first frame update
   public void reloadscene()
    {


        SceneManager.LoadScene(0);
        Time.timeScale = 1; 
    }

    public void quit()
    {
        Application.Quit();
    }
}
