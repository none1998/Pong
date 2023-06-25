using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Ball ball;

    private int playerScore;
    private int computerScore;

    [SerializeField]
    private Text playerSc;
    [SerializeField]
    private Text AISc;
    [SerializeField]
    private Text gameOver;

    [SerializeField]
    private Text Hardness;

    private void Start()
    {
        playerScore = Options.roundCounter;
        computerScore = Options.roundCounter;
        playerSc.text = playerScore.ToString();
        AISc.text = computerScore.ToString();
        if(Options.isHard == false)
        {
            Hardness.text = "Easy";
            StartCoroutine("DissapearDiff");
        }
        else
        {
            Hardness.text = "Hard";
            StartCoroutine("DissapearDiff");
        }
        
    }

    public void PlayerScores()
    {
        if (playerScore > 1)
        {
            playerScore--;
            playerSc.text = playerScore.ToString();
            this.ball.ResetBallPos();
            StartCoroutine(this.ball.ResetPosition());
        }   
        else
        {
            playerScore = 0;
            playerSc.text = playerScore.ToString();
            gameOver.text = "Player 1 Wins";
            this.ball.ResetBallPos();
            this.ball.ballSpeed = 0f;
            if (AIPaddle.IsSecondPlayer == false)
                StartCoroutine("GameWonFunc");
            if (AIPaddle.IsSecondPlayer == true)
                StartCoroutine("GameOverFunc");
        }
    }

    public void ComputerScores()
    {
        if (computerScore > 1)
        {
            computerScore--;
            AISc.text = computerScore.ToString();
            this.ball.ResetBallPos();
            StartCoroutine(this.ball.ResetPosition());
        }
        else
        {
            computerScore = 0;
            AISc.text = computerScore.ToString();
            if (AIPaddle.IsSecondPlayer == false)
            {
                gameOver.text = "AI Wins";
                this.ball.ResetBallPos();
                this.ball.ballSpeed = 0f;
                StartCoroutine("GameOverFunc");
            }
            else
            {
                gameOver.text = "Player 2 Wins";
                this.ball.ResetBallPos();
                this.ball.ballSpeed = 0f;
                StartCoroutine("GameOverFunc");
            }
        }
    }

    public IEnumerator GameOverFunc()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("MainMenu");
    }

    public IEnumerator GameWonFunc()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log(SceneManager.GetActiveScene().name);
        if(SceneManager.GetActiveScene().name == "Gameplay1") Select.Scene2 = true;
        if(SceneManager.GetActiveScene().name == "Gameplay2") Select.Scene3 = true;
        if(SceneManager.GetActiveScene().name == "Gameplay3") Select.Scene4 = true;
    }

    public IEnumerator DissapearDiff()
    {
        yield return new WaitForSeconds(2.8f);
        Hardness.text = "";
    }

    public void selectMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void selectRestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
