using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public int score;
    public Text scoreText;

    public void ScoreFunction()
    {
        score = score + 1;
        scoreText.text = " " + Mathf.Round(score);
        //scivi sul text il punteggio nuovo
        Debug.Log("+1");
    }
}
