using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    public GameObject platform;
    public Transform genPoint;
    public float distanceBetween;

    private float platformHeight = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < genPoint.position.y)
        {
            transform.position = new Vector3(0, transform.position.y + distanceBetween + platformHeight, 0);

            Instantiate(platform, transform.position, transform.rotation);
        }
            
    }
}
