using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class GMPvsP : MonoBehaviour
{
    public Ball ball;
    public Paddle Player1Paddle;
    public int Player1Score { get; private set; }
    public Text Player1ScoreText;
    public Paddle Player2Paddle;
    public int Player2Score { get; private set; }
    public Text Player2ScoreText;

    private void Start()
    {
        NewGame();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) {
            NewGame();
        }
    }

    public void NewGame()
    {
        SetPlayer1Score(0);
        SetPlayer2Score(0);
        StartRound();
    }

    public void StartRound()
    {
        this.Player1Paddle.ResPos();
        this.Player2Paddle.ResPos();
        this.ball.ResPos();
        this.ball.AddStartForce();
    }

    public void  Player1Scores()
    {
        SetPlayer1Score(this.Player1Score + 1);
        if (Player1Score <5)
        StartRound();
        else
        P1Wins();

    }

    public void Player2Scores()
    {
        SetPlayer2Score(this.Player2Score + 1);
        if (Player2Score <5)
        StartRound();
        else
        P2Wins();
    }

    private void SetPlayer1Score(int score)
    {
        this. Player1Score = score;
        this. Player1ScoreText.text = score.ToString();
    }

    private void SetPlayer2Score(int score)
    {
        this.Player2Score = score;
        this.Player2ScoreText.text = score.ToString();
    }
    public void P1Wins()
    {
        SceneManager.LoadScene(3);
    }

    public void P2Wins()
    {
        SceneManager.LoadScene(4);
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
      public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

}