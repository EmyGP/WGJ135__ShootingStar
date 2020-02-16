using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreCounter : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;

    public float timerGame;
    public Text winText;
    public Text schifText;
    public GameObject restartButton;
    public GameObject backButton;
    public GameObject spawner;

    public GameObject darkSky;

    private void Start()
    {
        spawner.SetActive(true);
        restartButton.SetActive(false);
        backButton.SetActive(false);
        score = 0;
        scoreText.text = "SCORE: " + Mathf.Round(score);
        StartCoroutine("Fade");
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
            winText.enabled = true;
        }
        else if (score <= 0)
        {
            schifText.enabled = true;
        }
        restartButton.SetActive(true);
        backButton.SetActive(true);
    }

    IEnumerator Fade()
    {
        for (float ft = 1; ft >= 0; ft -= 0.025f*Time.deltaTime)
        {
            Color c = darkSky.GetComponent<SpriteRenderer>().color;
            c.a = ft;
            darkSky.GetComponent<SpriteRenderer>().color = c;
            yield return null;
        }
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
}
