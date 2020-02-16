using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MM_Manager : MonoBehaviour
{
    public void RestartGameButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

    public void MainMenuButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
