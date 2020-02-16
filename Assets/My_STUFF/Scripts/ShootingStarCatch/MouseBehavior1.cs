using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseBehavior1 : MonoBehaviour
{
    public ScoreCounter scoreCounter;
    //public GameObject[] starPrefab;
    public GameObject starPrefabObj;
    private Collider2D starCollider;

    private void Start()
    {
        //foreach (GameObject starP in starPrefab)
        //{
                ////per ogni gameobject nell'array starPrefab definisco la mia variabile starcollider come il collider2D di starP
        //    starCollider = starP.GetComponent<CircleCollider2D>();
        //}
        starCollider = starPrefabObj.GetComponent<CircleCollider2D>();
    }


    public void OnMouseDown()
    {
        scoreCounter.ScoreFunction();
        starCollider.enabled = false;
    }
}
