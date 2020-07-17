using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LobbySceneScript : MonoBehaviour
{
    public string LoadLevel;
    public void OnPlay()
    {
        SceneManager.LoadScene(LoadLevel);
    }
}
