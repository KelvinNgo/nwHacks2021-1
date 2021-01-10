using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    public GameObject platform;
    public GameObject trampoline;
    public GameObject enemy;
    public GameObject disappearing;
    public Transform genPoint;
    
    private float distanceBetween;
    private float platformHeight = 1;
    private float screenWidth = 14;
    private int platformType;

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
            float distanceX = Random.Range(-screenWidth/2, screenWidth/2);
            
            transform.position = new Vector3(distanceX, transform.position.y + distanceBetween + platformHeight, 0);

            platformType = Random.Range(0, 10);
            switch(platformType) {
            case 0:
                Instantiate(platform, transform.position, transform.rotation);
                Instantiate(trampoline, new Vector3(transform.position.x+Random.Range(-1,1), transform.position.y+1, 0), transform.rotation);
                break;
            case 1:
                Instantiate(platform, transform.position, transform.rotation);
                Instantiate(enemy, new Vector3(transform.position.x, transform.position.y+1, 0), transform.rotation);
                break;
            default:
                Instantiate(platform, transform.position, transform.rotation);
                break;
            }
        }
    }
}
