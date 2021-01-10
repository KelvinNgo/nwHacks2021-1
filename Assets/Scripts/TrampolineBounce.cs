using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrampolineBounce : MonoBehaviour
{
    public int springForce;
    public Collision2D collision;
    public GameObject subject;

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision) {
        collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, springForce));
        Debug.Log("What a bounce");
    }
}
