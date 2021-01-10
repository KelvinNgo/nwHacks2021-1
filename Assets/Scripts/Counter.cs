using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Counter : MonoBehaviour
{
    private TextMeshProUGUI counterText; 
    private int score;
    // counterText = GetComponent.GetComponentInChildren<CounterText>();
    // Start is called before the first frame update
    void Start()
    {
        counterText = GetComponent<TextMeshProUGUI>();
        score = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        counterText.text = score.ToString();
        score++;
    }
}
