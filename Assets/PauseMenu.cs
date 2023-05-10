using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool isPause;
    [SerializeField] GameObject pauseMenu;
    
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)) 
        {
            if (isPause )
            {
                Resume();
            }

            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        LevelManager.canMove = false;
        isPause = false;
    }
    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;        
        LevelManager.canMove = true;
        isPause = true;
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
        LevelManager.canMove = false;
        isPause=false;
    }
}
