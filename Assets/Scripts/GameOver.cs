using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private AudioSource source;
    private Rigidbody2D myRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
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
        SceneManager.LoadScene("Menu");
    }
}
