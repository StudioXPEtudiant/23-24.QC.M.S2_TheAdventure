using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Button2 : MonoBehaviour
{
   public void ButtonStart() 
   {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }
    public void ButtonQuit()
    {
        Application.Quit();
    }

}
