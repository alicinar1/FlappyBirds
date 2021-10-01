using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour
{
    [SerializeField] GameObject gameOverUI;
    [SerializeField] Score score;
    [SerializeField] TMP_Text scoreText;
    [SerializeField] TMP_Text highScore;
    public void GameEnd()
    {
        score.GetComponent<Score>().enabled = false;

        gameOverUI.SetActive(true);

        scoreText.enabled = false;

        highScore.text = $"High Score is: {PlayerPrefs.GetInt("HighScore")}";
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(1);
        Debug.Log("RestartLevel");
    }

    public void QuitGame()
    {
        SceneManager.LoadScene(0);
    }
}
