using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseBehavior : MonoBehaviour
{
    public ScoreCounter scoreCounter;
    private Collider2D starCollider;

    private void Start()
    {
        starCollider = gameObject.GetComponent<CircleCollider2D>();
    }


    private void OnMouseDown()
    {
        scoreCounter.ScoreFunction();
        starCollider.enabled = false;
    }
}
