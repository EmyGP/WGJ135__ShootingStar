using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner1 : MonoBehaviour
{
    public Transform[] spawnPoint;
    public GameObject asteroid;

    public void ShootStars()
    {
        foreach (Transform sP in spawnPoint)
        {
            //uso il foreach così posso spararne anche più di uno nello stesso momento
            Instantiate(asteroid, sP.position, sP.rotation);
            //aggiungere ciò che le sparia per aria
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            ShootStars();
        }        
    }
}
