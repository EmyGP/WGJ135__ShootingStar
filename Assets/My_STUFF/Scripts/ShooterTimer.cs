using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterTimer : MonoBehaviour
{
    public float timerGame = 60;
    public float timerShoot_1 = 1;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("TimerShooter");      
    }

    //coroutine che gestisce il timer degli spawn point. Quando il timer arriv a a0 lo spawn deve sparare di nuovo e il timer ripartire
    IEnumerator TimerShooter()
    {
        for(float i = 60; i > timerShoot_1; i--)
        {
            timerShoot_1 -= i*timerShoot_1*Time.deltaTime;
            yield return null;
        }
        //if (timerShoot_1 >= 0)
        //{
        //    timerShoot_1 -= Time.deltaTime;
        //    yield return timerShoot_1;
        //}
        //else
        //{
        //    //shoot altre stelle
        //    timerShoot_1 = 10;
        //    yield return null;
        //}
    }

    // ci vorrebbe più una coroutine così posso fermarla
    void Update()
    {
        timerGame -= Time.deltaTime;      
    }
}
