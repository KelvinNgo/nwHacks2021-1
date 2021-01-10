using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed;
    public float jumpSpeed;
    private Rigidbody2D myRigidbody;

    private bool isGrounded = true;

    private bool facingRight = true;

    // Start is called before the first frame update
    void Start() 
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate() 
    {
        Move(Input.GetAxisRaw("Horizontal"));
        if(Input.GetButtonDown("Jump") || Input.GetKeyDown(KeyCode.W))
        {
            Jump();
        }
    }

    void OnCollisionEnter2D(Collision2D theCollision)
    {
        if(theCollision.gameObject.tag == "platform")
        {
            isGrounded = true;
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }

    public void Move(float horizontal)
    {
        Vector2 move = myRigidbody.velocity;
        move.x = horizontal * moveSpeed;
        myRigidbody.velocity = move;
        if (facingRight && horizontal < 0)
        {
            Flip();
        } else if(!facingRight && horizontal > 0)
        {
            Flip();
        }
    }

    public void Jump()
    {
        if(isGrounded)
        {
            myRigidbody.velocity += jumpSpeed * Vector2.up;
            isGrounded = false;
        }
    }
}
