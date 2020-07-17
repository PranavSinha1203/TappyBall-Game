using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    public GameObject GameOverPanel;
    public GameObject GamePausePanel;
    public GameObject PauseButton;
    public string Lobbyscene;
    public string Gamescene;
    private int Score;
    public Text GameOverScore;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        OnGameOver();
        GameScore();
      
    }

    void OnGameOver()
    {
        if(PlayerScript.instance.GameOver)
        {
            GameOverPanel.SetActive(true);
        }
    }

    public void OnGamePause()
    {
        Time.timeScale = 0;
        GamePausePanel.SetActive(true);
        PauseButton.SetActive(false);
    }

    public void Resume()
    {
        Time.timeScale = 1;
        GamePausePanel.SetActive(false);
        PauseButton.SetActive(true);
    }

    public void MainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(Lobbyscene);
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(Gamescene);
    }

    public void Exit()
    {
        Application.Quit();
    }

    void GameScore()
    {
        Score = PlayerScript.instance.score;
        GameOverScore.text = Score.ToString();
    }


}
