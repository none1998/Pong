using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Select : MonoBehaviour
{
    public static bool Scene1 = true;
    public static bool Scene2 = false;
    public static bool Scene3 = false;
    public static bool Scene4 = false;
    public Button scene1;
    public Button scene2;
    public Button scene3;
    public Button scene4;

    private void Update()
    {
        if (Scene1 == true)
        {
            scene1.interactable = true;
        }
        else
        {
            scene1.interactable = false;
        }

        if (Scene2 == true)
        {
            scene2.interactable = true;
        }
        else
        {
            scene2.interactable = false;
        }

        if (Scene3 == true)
        {
            scene3.interactable = true;
        }
        else
        {
            scene3.interactable = false;
        }

        if (Scene4 == true)
        {
            scene4.interactable = true;
        }
        else
        {
            scene4.interactable = false;
        }
    }

    public void select()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void select1()
    {
        SceneManager.LoadScene("Gameplay1");
    }

    public void select2()
    {
        SceneManager.LoadScene("Gameplay2");
    }

    public void select3()
    {
        SceneManager.LoadScene("Gameplay3");
    }

    public void selectMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
