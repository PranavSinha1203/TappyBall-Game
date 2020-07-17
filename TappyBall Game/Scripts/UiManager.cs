using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UiManager : MonoBehaviour
{
    public GameObject StartPanel;
    public GameObject GameOverPanel;
    public GameObject TapText;
    string UserLevel;
    void Start()
    {
        UserLevel = "1";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameStart()
    {
        
    }

    public void GameOver()
    {

    }

    public void Play()
    {
        SceneManager.LoadScene(UserLevel);
    }
}
