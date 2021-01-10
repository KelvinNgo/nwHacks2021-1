 using UnityEngine;
 using System.Collections;
 
 public class TrampolineBounce : MonoBehaviour {
     public float springForce = 1000;
     private Collision2D collision;
     private bool bouncing = false;
 
     void OnCollisionEnter2D(Collision2D coll) {
         if (!bouncing) {
             bouncing = true;
             collision = coll;
         }
     }
 
     void FixedUpdate () {
         if (bouncing && !collision.gameObject.tag.Equals("platform") && !collision.gameObject.tag.Equals("outofbounds") 
         && !collision.gameObject.tag.Equals("patrolenemy")) {
             Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D> ();
             rb.velocity = new Vector3 (0, 0, 0);
             rb.AddForce (new Vector2 (0f, springForce));
             bouncing = false;
         }
     }
 }
