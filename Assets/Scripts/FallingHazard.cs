using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingHazard : MonoBehaviour
{
    public float frequency = 0.5f;
    public GameObject HazardBlock;
 
    private void OnEnable()
    {
        StartCoroutine(Spawn());
    }
 
    private void OnDisable()
    {
        StopAllCoroutines();
    }
 
    private IEnumerator Spawn()
    {
        WaitForSeconds delay = new WaitForSeconds(frequency);
 
        while(true)
        {
            yield return delay;
 
            Destroy(Instantiate(HazardBlock, transform.position, Quaternion.identity), 5f);
 
        }
        }
}
