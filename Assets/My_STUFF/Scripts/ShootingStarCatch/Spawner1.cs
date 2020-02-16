using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner1 : MonoBehaviour
{
    public Transform[] spawnPoint;
    public GameObject asteroid;
    public Rigidbody2D asteroidRb;
    public int shootForce;

    public void ShootStars()
    {
        //uso il foreach così posso spararne anche più di uno nello stesso momento
        foreach (Transform sP in spawnPoint)
        {
            //Instantiate(asteroid, sP.position, sP.rotation);
            //aggiungere ciò che le sparia per aria
            Rigidbody2D starInstance;
            starInstance = Instantiate(asteroidRb, sP.position, sP.rotation) as Rigidbody2D;
            starInstance.AddForce(sP.up * shootForce);
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
