using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovment : MonoBehaviour
{
    //public float _moveSpeed = 10f;
    //public Rigidbody2D rb;
    public Vector3 startPosition = new Vector3(0,0,0);
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float xInput = SimpleInput.GetAxis("Horizontal");
        float yInput = SimpleInput.GetAxis("Vertical");
        rb.velocity = new Vector2(xInput * 0.3f , yInput * 0.3f);
    }



    public void resetPosition()
    {
        transform.position = startPosition;
    }
}
