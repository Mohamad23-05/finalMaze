using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ButtonManger : MonoBehaviour
{
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
            //showAnswer();
        }
    }

    public void showAnswer(GameObject Answers)
    {
        if(Answers.gameObject.tag == "Answer")
        {
            Answers.SetActive(true);
        }
    }
}
