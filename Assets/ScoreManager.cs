using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
    public static ScoreManager instance = null;
    public Text scoreText;
    public Text maxScoreText;
    private int maxScore = 0;
    private int score = 0;

    // Use this for initialization
    void Start () {
        if (instance == null)
        {
            instance = this;
        } else if (instance != this)
        {
            Destroy(gameObject);
        }
        updateMaxPoints();
    }
    
    public void addScore(int points)
    {
        score += points;
        scoreText.text = "Score: " + score;
        updateMaxPoints();
    }

    public void updateMaxPoints()
    {
        maxScore = PlayerPrefs.GetInt("maxScore");
        if (maxScore < score)
        {
            maxScore = score;
            PlayerPrefs.SetInt("maxScore", maxScore);
            PlayerPrefs.Save();
        }
        maxScoreText.text = "Max Score: " + maxScore;
    }
}
