using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreCounter : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;

    public float timerGame = 60;
    public Text winText;
    public Text schifText;
    public GameObject restartButton;
    public GameObject spawner;

    private void Start()
    {
        spawner.SetActive(true);
        restartButton.SetActive(false);
        score = 0;
        scoreText.text = "SCORE: " + Mathf.Round(score);
    }

    public void ScoreFunction()
    {
        score += 1;
        scoreText.text = "SCORE: " + Mathf.Round(score);
        Debug.Log("+1");
    }

    private void EndScreen()
    {
        if (score > 0)
        {
            //messaggio: hai beccato ___ stelle! speriamo che il desiderio si avveri
            winText.enabled = true;
        }
        else if (score <= 0)
        {
            //fai schifo, non realizzerai mai i tuoi sogni. opure hai bisogno degli occhiali.
            schifText.enabled = true;
        }
        restartButton.SetActive(true);
    }

    private void Update()
    {
        if (timerGame > 0)
        {
            timerGame -= Time.deltaTime;
        }
        else if (timerGame <= 0)
        {
            spawner.SetActive(false);
            EndScreen();
        }
    }

    public void RestartGameButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}
