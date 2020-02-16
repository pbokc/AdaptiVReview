using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchScene()
    {
        SceneManager.LoadScene("AboutScene");
    }

    public void switchSceneToQuestion() {
        SceneManager.LoadScene("QuestionOne");
    }

    public void switchSceneToResult() {
        SceneManager.LoadScene("ResultScene");
    }

}
