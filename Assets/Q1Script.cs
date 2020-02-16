using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Q1Script : MonoBehaviour
{
    public string type;
    public TextMeshProUGUI text;
    public TextMeshProUGUI title;
    public GameObject tac;
    public GameObject aud;
    public GameObject vis;
    public GameObject move;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IsTactile()
    {
        type = " tactile";
        ChangeScreen();
    }

    public void IsVisual()
    {
        type = " visual";
        ChangeScreen();
    }

    public void IsAudio()
    {
        type = "n audiotory";
        ChangeScreen();
    }

    public void ChangeScreen()
    {
        title.SetText("Results");
        text.SetText("You are a" + type + " learner!\n\nClick here to continue to the tactile learing activty.");
        tac.SetActive(false);
        aud.SetActive(false);
        vis.SetActive(false);
        move.SetActive(true);
    }

    public void EnterWorld()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
