using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BgGenerator : MonoBehaviour
{
    public GameObject background;
    public Transform genPoint;
    private float backgroundHeight = 32;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < genPoint.position.y)
        {
            transform.position = new Vector3(0, transform.position.y + backgroundHeight, 0);

            GameObject newBG = Instantiate(background, transform.position, transform.rotation);
            newBG.transform.parent = GameObject.Find("Grid").transform;
        }
            
    }
}
