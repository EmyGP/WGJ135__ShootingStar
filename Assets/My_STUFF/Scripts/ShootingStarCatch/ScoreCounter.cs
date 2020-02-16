using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;

    public GameObject starPrefab;
    private Collider2D starC;


    private void Start()
    {
        Collider2D starC = starPrefab.gameObject.GetComponent<Collider2D>();
        score = 0;
        scoreText.text = "SCORE: " + Mathf.Round(score);
    }

    private void OnMouseDown(Collider2D starc)
    {
        ScoreFunction();
        starC.enabled = false;
    }

    public void ScoreFunction()
    {
        score += 1;
        //scoreText.text = "SCORE: " + score.ToString();
        scoreText.text = "SCORE: " + Mathf.Round(score);
        Debug.Log("+1");
    }
}
