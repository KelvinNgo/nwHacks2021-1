using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    public GameObject platform;
    public Transform genPoint;
    
    private float distanceBetween;
    private float platformHeight = 1;
    private float screenWidth = 14;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < genPoint.position.y)
        {
            distanceBetween = Random.Range(1, 6);
            transform.position = new Vector3(Random.Range(-screenWidth/2, screenWidth/2), transform.position.y + distanceBetween + platformHeight, 0);

            Instantiate(platform, transform.position, transform.rotation);
        }
            
    }
}
