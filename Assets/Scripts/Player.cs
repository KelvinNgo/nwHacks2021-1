using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
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
        if(Input.GetButtonDown("Jump") || Input.GetKeyDown(KeyCode.W))
        {
            Jump();
        }

        if (myRigidbody.velocity.y > 0)
        {
            Physics2D.IgnoreLayerCollision(8, 10, true);
        }
        else
        {
            Physics2D.IgnoreLayerCollision(8, 10, false);
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
