﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantBullet : MonoBehaviour
{
    float moveSpeed = 7f;

    Rigidbody2D rb;

    Player target;
    Vector2 moveDirection;

    void Start() {
        rb = GetComponent<Rigidbody2D> ();
        target = GameObject.FindObjectOfType<Player>();
        moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
        rb.velocity = new Vector2 (moveDirection.x, moveDirection.y);
        Destroy (gameObject, 3f);
    }

    void OnTriggerEnter2D (Collider2D col) {
        if(col.gameObject.name.Equals ("Player")) {
            Debug.Log("Ouch!");
            Destroy (gameObject);
        }
    }
}
