﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructor : MonoBehaviour
{
    public GameObject destPoint;
    // Start is called before the first frame update
    void Start()
    {
        destPoint = GameObject.Find("DestructionPoint");
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < destPoint.transform.position.y)
        {
            Destroy(gameObject);
        }
    }
}
