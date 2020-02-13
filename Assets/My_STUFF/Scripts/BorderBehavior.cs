using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderBehavior : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "asteroid")
        {
            //other.gameObject.SetActive(false);
            Destroy(other.gameObject);
            //distruggi asteroide
            //animazioni bellissime
            //RIDURRE lo score
            //spawna altri N ateroidi???
        }
    }
}
