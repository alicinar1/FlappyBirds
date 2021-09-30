using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private TMP_Text yourScoreText;
    [SerializeField] private float scoreMultiplier = 100f;
    //public int score;
    private int score = 1;
    private float scoreF;

    private string highScoreKey = "HighScore";


    public void AddScore()
    {
        enabled = true;
        Debug.Log("True");
    }

    private void Update()
    {
        scoreF += score * Time.deltaTime * scoreMultiplier;
        PrintScore(Mathf.RoundToInt(scoreF));
    }

    public void PrintScore(int score)
    {
        scoreText.text = score.ToString();

        int currentHighScore = PlayerPrefs.GetInt(highScoreKey, 0);

        if (score > currentHighScore)
        {
            PlayerPrefs.SetInt(highScoreKey, score);
        }

        yourScoreText.text = $"Your score is: {score}";
    }



}
