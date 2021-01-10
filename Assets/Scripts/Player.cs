using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float moveSpeed;
    public float jumpSpeed;
    public float fallSpeed;
    private Rigidbody2D myRigidbody;

    private bool isGrounded = true;
    private bool facingRight = true;
    private bool isJumping;
    private float movementInput;

    private AudioSource source;

    // Start is called before the first frame update
    void Start() 
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        source = GetComponent<AudioSource>();
        isJumping = false;
    }

    void Update()
    {
        movementInput = Input.GetAxisRaw("Horizontal");
        if(Input.GetButtonDown("Jump") || Input.GetKeyDown(KeyCode.W))
        {
            isJumping = true;
        }

        
    }

    void FixedUpdate()
    {
        if(isJumping)
        {
            Jump();
            isJumping = false;
        }

        Move(movementInput);

        if(myRigidbody.velocity.y < 0) {
            myRigidbody.velocity += Vector2.up * Physics2D.gravity.y * Time.deltaTime * fallSpeed;
        }
    }

    void OnCollisionEnter2D(Collision2D theCollision)
    {
        if(theCollision.gameObject.tag == "platform")
        {
            isGrounded = true;
        }
        if(theCollision.gameObject.tag == "outofbounds")
        {
            SceneManager.LoadScene("Menu");
        }
        if(theCollision.gameObject.tag == "patrolenemy")
        {
            SceneManager.LoadScene("Menu");
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
            source.Play();
        }
    }
}
