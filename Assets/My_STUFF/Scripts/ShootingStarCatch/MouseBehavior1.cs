using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseBehavior1 : MonoBehaviour
{
    private ScoreCounter scoreCounter;
    //public GameObject[] starPrefab;
    //private GameObject starPrefabObj;
    private Collider2D starCollider;

    private void Start()
    {
        scoreCounter = GameObject.FindWithTag("GameManager").GetComponent<ScoreCounter>();
        //foreach (GameObject starP in starPrefab)
        //{
                ////per ogni gameobject nell'array starPrefab definisco la mia variabile starcollider come il collider2D di starP
        //    starCollider = starP.GetComponent<CircleCollider2D>();
        //}
        starCollider = this.gameObject.GetComponent<CircleCollider2D>();
    }


    public void OnMouseDown()
    {
        scoreCounter.ScoreFunction();
        starCollider.enabled = false;
    }
}
