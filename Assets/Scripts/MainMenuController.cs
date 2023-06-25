using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void selectMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void selectRestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void PlayAdventure()
    {
        AIPaddle.IsSecondPlayer = false;
        SceneManager.LoadScene("StageSelect");
    }

    public void Play2Player()
    {
        AIPaddle.IsSecondPlayer = true;
        SceneManager.LoadScene("StageSelect");
    }

    public void PlayOptions()
    {
        SceneManager.LoadScene("Options");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
