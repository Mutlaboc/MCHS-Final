using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
  
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            LoadMainMenu();
        }
    }

    public void StartQuiz()
    {
        SceneManager.LoadScene("Game");
    }
    public void StartTraining()
    { SceneManager.LoadScene("Train"); 
    }
    public void  LoadMainMenu()
    {
        SceneManager.LoadScene("Start Menu");
    }
    public void QuitApp()
    {
        Application.Quit();
    }
}
