using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;

    private void Start()
    {
        score = 0;
        scoreText.text = "SCORE: " + Mathf.Round(score);
    }

    public void ScoreFunction()
    {
        score += 1;
        //scoreText.text = "SCORE: " + score.ToString();
        scoreText.text = "SCORE: " + Mathf.Round(score);
        Debug.Log("+1");
    }
}
