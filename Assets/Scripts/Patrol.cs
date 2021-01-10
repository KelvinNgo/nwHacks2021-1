using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Patrol : MonoBehaviour
{
    public float speed;
    public float distance;
    public Transform groundDetection;

    private bool movingRight = true;
    private Rigidbody2D myRigidbody;
    private AudioSource source;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        source = GetComponent<AudioSource>();
    }

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance);
        if(groundInfo.collider == false){
            if(movingRight == true){
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight = false;
            } else {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D theCollision)
    {
        if(theCollision.gameObject.tag == "Player")
        {
            StartCoroutine (PlayerGameOver());
        }
    }

        private IEnumerator PlayerGameOver()
    {
        source.Play();
        yield return new WaitWhile (()=> source.isPlaying);
        SceneManager.LoadScene("Gameover");
    }
}

