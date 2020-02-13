using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseBehavior : MonoBehaviour
{
    public ScoreCounter scoreCounter;

    private void OnMouseDown()
    {
        scoreCounter.ScoreFunction();
    }
}
