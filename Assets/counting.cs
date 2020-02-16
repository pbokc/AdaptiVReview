using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class counting : MonoBehaviour
{
    public int numBalls;
    public TextMeshProUGUI text;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        numBalls++;
        text.SetText("Balls counted: " + numBalls);
    }

    public void OnTriggerExit(Collider other)
    {
        numBalls--;
        text.SetText("Balls counted: " + numBalls);
    }

}
