using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseBehavior1 : MonoBehaviour
{
    private ScoreCounter scoreCounter;
    private Collider2D starCollider;

    private void Start()
    {
        //richiamo lo script attaccato all'object GM in scena
        scoreCounter = GameObject.FindWithTag("GameManager").GetComponent<ScoreCounter>();
        starCollider = this.gameObject.GetComponent<CircleCollider2D>();
    }


    public void OnMouseDown()
    {
        //chiamo lo funzione che aumenta lo score + spengo il collidr così da contre 2 volte la stessa stella
        scoreCounter.ScoreFunction();
        starCollider.enabled = false;
    }
}
