using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public Paddle PlayerPaddle;
    public int PlayerScore { get; private set; }
    public Text PlayerScoreText;
    public Paddle ComputerPaddle;
    public int ComputerScore { get; private set; }
    public Text ComputerScoreText;

    private void Start()
    {
        NewGame();
    }

    public void NewGame()
    {
        SetPlayerScore(0);
        SetComputerScore(0);
        StartRound();
    }

    public void StartRound()
    {
        this.PlayerPaddle.ResPos();
        this.ComputerPaddle.ResPos();
        this.ball.ResPos();
        this.ball.AddStartForce();
    }

    public void PlayerScores()
    {
        
        SetPlayerScore(this.PlayerScore + 1);       
        if (PlayerScore <5)
        StartRound();
        else
        PWins();
        
    }

    public void ComputerScores()
    {      
        SetComputerScore(this.ComputerScore + 1);      
        if (ComputerScore <5)
        StartRound();
        else
        CWins();
    }

    private void SetPlayerScore(int score)
    {
        this.PlayerScore = score;
        this.PlayerScoreText.text = score.ToString();
    }

    private void SetComputerScore(int score)
    {
        this.ComputerScore = score;
        this.ComputerScoreText.text = score.ToString();
    }

    public void PWins()
    {
        SceneManager.LoadScene(5);
    }

    public void CWins()
    {
        SceneManager.LoadScene(6);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void PauseGame()
    {
        if(Time.timeScale==1)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
}