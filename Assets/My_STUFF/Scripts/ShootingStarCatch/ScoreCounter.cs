using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public int score;
    public Text scoreText;

    private void Start()
    {
        score = 0;
        scoreText.text = " ";
    }

    public void ScoreFunction()
    {
        score = score + 1;
        scoreText.text = " " + Mathf.Round(score);
        Debug.Log("+1");
    }
}
