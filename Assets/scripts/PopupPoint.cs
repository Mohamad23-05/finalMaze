using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupPoint : MonoBehaviour
{
    public GameObject questions;
    // Start is called before the first frame update
    void Start()
    {
        questions.SetActive(false);
    }
    public void OnTriggerEnter2D(Collider2D player) 
    {
        //by hitting the point
        if(player.tag == "Player")
        {
            questions.SetActive(true);
            Debug.Log("Question is on");
        }    
    } 
}
