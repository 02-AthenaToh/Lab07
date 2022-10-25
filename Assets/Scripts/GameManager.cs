using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager thisManager = null;  
    [SerializeField] private Text Txt_Score = null;
    [SerializeField] private Text Txt_Message = null;
    private int score = 0;

    private float scoreInterval = 1f;
    private float nextScore = 2.5f;

    public Text scoreText;

    void Start()
    {
        thisManager = this;
        Time.timeScale = 0;
    }

    void Update()
    {
        if (Time.timeScale == 0 && Input.GetKeyDown(KeyCode.Return))
            StartGame();

        if (Time.time >= nextScore)
        {
            nextScore = Time.time + scoreInterval;
            score++;
        }
        scoreText.text = "Score: " + score;
    }

    public void UpdateScore(int value)
    {
        score += value;
        Txt_Score.text = "SCORE : " + score;
    }

    private void StartGame()
    {
        score = 0;
        Time.timeScale = 1;
        Txt_Message.text = "";
        Txt_Score.text = "SCORE : 0";
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        Txt_Message.text = "GAMEOVER! \nPRESS ENTER TO RESTART GAME.";
        Txt_Message.color = Color.red;
    }
}
