using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public float jumpSpeed;
    private Rigidbody2D myRigidbody;
    //private Transform transform;

    // Start is called before the first frame update
    void Start() 
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        //transform = this.transform;
    }

    // Update is called once per frame
    void FixedUpdate() 
    {
        Move(Input.GetAxisRaw("Horizontal"));
        if(Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }

    public void Move(float horizontal)
    {
        Vector2 move = myRigidbody.velocity;
        move.x = horizontal * moveSpeed;
        myRigidbody.velocity = move;
    }

    public void Jump()
    {
        myRigidbody.velocity += jumpSpeed * Vector2.up;
    }
}
