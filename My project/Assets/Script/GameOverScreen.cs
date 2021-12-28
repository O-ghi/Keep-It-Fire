using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class GameOverScreen : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI bestScore;
    public GameObject score;

    //
    Text highestScoreText;

    private void Start()
    {
        bestScore.text = "Best Score: " + PlayerPrefs.GetString("BestScore", "0");
    }



    public void Setup()
    {

        int scoreInt = int.Parse(score.GetComponent<Text>().text);
        int bestScoreint = int.Parse(PlayerPrefs.GetString("BestScore", "0"));
        Debug.Log(bestScoreint);
        try
        {
            if (scoreInt > bestScoreint)
            {
                PlayerPrefs.SetString("BestScore", scoreInt.ToString());
                bestScore.text = "Best Score: " + scoreInt.ToString();
            }
        }
        catch (Exception e)
        {
            Debug.Log(e);
        }
        gameObject.SetActive(true);
        scoreText.text = "Your Score: " + scoreInt.ToString();

    }
}
