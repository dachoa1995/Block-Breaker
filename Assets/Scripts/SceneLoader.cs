using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene((currentSceneIndex + 1) % SceneManager.sceneCountInBuildSettings);

        if(SceneManager.sceneCountInBuildSettings == currentSceneIndex + 1)
        {
            FindObjectOfType<GameSession>().DestroyGameStatus();
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadStartGame()
    {
        SceneManager.LoadScene(0);
    }
}
