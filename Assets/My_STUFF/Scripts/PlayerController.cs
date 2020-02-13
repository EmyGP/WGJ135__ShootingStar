using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Update()
    {
        //il player si muove seguendo la posizione del mouse sullo schermo
        //Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //transform.position = mousePos;
        transform.position = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x,transform.position.y);
    }
}
