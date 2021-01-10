using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantEnemyBullet : MonoBehaviour
{
    [SerializeField]
    GameObject bullet;

    float fireRate;
    float nextFire;

    void Start()
    {
        fireRate = 5f;
        nextFire = Time.time;
    }

    void Update()
    {
        CheckIfTimeTOFire();
    }

    void CheckIfTimeToFire()
    {
        if(Time.time > nextFire) {
            Instantiate (bullet, transformposition, Quaternion.identity);
            nextFire = Time.time + fireRate
        }
    }
}
