using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingHazard : MonoBehaviour
{
    public GameObject HazardBlock;
    private float SpawnHazardTimer = 2f;

    void Start()
    {
        
    }

    void Update()
    {
        InstantiateHazard();
    }

    void InstantiateHazard()
    {
        SpawnHazardTimer -= Time.deltaTime;
        if(SpawnHazardTimer <= 0) {
            Instantiate (HazardBlock, new Vector2(-1.76f, -0.55f), Quaternion.identity);
            SpawnHazardTimer = 2f;
        }
    }
}
