using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;


public class ButtonManger : MonoBehaviour
{
    //public GameObject player;
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("QuitGame");
    }
    public void Restart(GameObject player)
    { 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void destroyPoint(GameObject Points)
    {
        if(Points.gameObject.tag == "Point")
        {
            Destroy(Points.gameObject);
        }
    }

    public void destroyPanel(GameObject panels)
    {
        if(panels.gameObject.tag == "Panel")
        {
            Destroy(panels.gameObject);
            //showAnswer();
        }
    }

    public void destroyAnswer(GameObject Answers)
    {
        if(Answers.gameObject.tag == "Answer")
        {
            Destroy(Answers.gameObject);
           
        }

    }
    public void destroyChar(GameObject CharWahl)
    {
        if(CharWahl.gameObject.tag == "CharWahl")
        {
            Destroy(CharWahl.gameObject);
        }
    }
    public void showAnswer(GameObject Answers)
    {
        if(Answers.gameObject.tag == "Answer")
        {
            Answers.SetActive(true);
        }
        if(Answers.gameObject.tag == "CharWahl")
        {
            Answers.SetActive(true);
        }
    }         
    public void Score()
    {
        // Increment the score value
        Debug.Log("score is " + ScoreScript.scoreValue.ToString());
        ScoreScript.scoreValue += 3;
    }



public void ChangeScene()
{
    SceneManager.LoadScene("SceneFrau");
}



}
