using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallOffGameOver : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D theCollision)
    {
        if (theCollision.gameObject.tag == "platform")
        {
            //Call game over
        }
    }
}
