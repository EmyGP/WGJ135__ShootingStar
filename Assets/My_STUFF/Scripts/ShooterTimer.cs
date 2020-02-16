using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterTimer : MonoBehaviour
{
    public float timerGame = 60;
    public float timerShoot_1 = 10;

    public Spawner1 shootStars;
    public Spawner1 shootStars2;

    void Start()
    {
        StartCoroutine("TimerShooter");
    }

    //coroutine che gestisce il timer degli spawn point. Quando il timer arriv a a0 lo spawn deve sparare di nuovo e il timer ripartire
    IEnumerator TimerShooter()
    {
        while (timerShoot_1 > 0)
        {
            timerShoot_1 -= Time.deltaTime;
            yield return null;
        }
        shootStars.ShootStars();
        shootStars2.ShootStars();
        //timerShoot_1 = 8;
        yield return null;
    }

    // ci vorrebbe più una coroutine così posso fermarla
    void Update()
    {
        timerGame -= Time.deltaTime;      
    }
}
