using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    private int now = 3;
    public int score = 0;
    public int highScore = 0;
    string highScoreKey = "HighScore";

    void Start()
    {
        //scoreLabel.text = score.ToString();
        scoreText.text = score.ToString();
        //get high score if it is there, otherwise 0
        highScore = PlayerPrefs.GetInt(highScoreKey, 0);
    }

    void Update()
    {
        InvokeRepeating("AdToScore", 0, 10);
    }

    void AdToScore()
    {
        if (now > 0)
        {
            score = score + 1;
            scoreText.text = score.ToString();
        }
    }

    void OnDisable()
    {
        //if score greater than high score, set new high score and save 
        if (score > highScore)
        {
            PlayerPrefs.SetInt(highScoreKey, score);
            PlayerPrefs.Save();
        }
    }
}