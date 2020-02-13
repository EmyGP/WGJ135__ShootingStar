using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PBall_behavior : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "asteroid")
        {
            other.gameObject.SetActive(false);
            //distruggi asteroide
            //animazioni bellissime
            //aumenta lo score
            //spawna altri N ateroidi???
        }
    }
}
