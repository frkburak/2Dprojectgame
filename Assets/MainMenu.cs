using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    public void PlayGme()
    {
        SceneManager.LoadScene(1);
    }
    public void ExitGame() 
    {
        Application.Quit();
        Debug.Log("Application Quit");
    }
}
