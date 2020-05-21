using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Game");
        Score.ScoreValue = 0;
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void GoToSpaceshipsScreen()
    {
        SceneManager.LoadScene("SpaceshipsScreen");
    }
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}