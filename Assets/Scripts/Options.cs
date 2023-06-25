using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Options : MonoBehaviour
{
    public static int roundCounter = 5;
    public static bool isHard = false;
    public Text roundCounterText;
    public Text isHardText;

    public void RoundsPlus()
    {
        roundCounterText.text = roundCounter.ToString();
        if (roundCounter < 10)
        roundCounter++;
        roundCounterText.text = roundCounter.ToString();
    }

    public void RoundsMinus()
    {
        roundCounterText.text = roundCounter.ToString();
        if (roundCounter > 3)
        roundCounter--;
        roundCounterText.text = roundCounter.ToString();
    }

    public void DifficultyEasy()
    {
        isHard = false;
        isHardText.text = "Easy";
    }

    public void DifficultyHard()
    {
        isHard = true;
        isHardText.text = "Hard";
    }

    public void ReturnToMM()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
