using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterTimer : MonoBehaviour
{
    public float timerShoot_1 = 10;
    public float timerShootBis;

    public Spawner1 shootStars;

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
        timerShoot_1 = timerShootBis;
        yield return null;
    }

    // ci vorrebbe più una coroutine così posso fermarla
    void Update()
    {
        if (timerShoot_1 <= 0)
        {
            StartCoroutine("TimerShooter");
        }
    }
}
