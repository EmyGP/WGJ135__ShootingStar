using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform[] spawnPoint;
    public GameObject asteroid;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            foreach (Transform sP in spawnPoint)
            {
                Instantiate(asteroid, sP.position, sP.rotation);
            }
        }

        
    }
}
