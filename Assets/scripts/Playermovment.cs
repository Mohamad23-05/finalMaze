using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovment : MonoBehaviour
{
    public float _moveSpeed;
    public Rigidbody2D _rigidBody;
    private Vector2 _moveDirection;
    [SerializeField] private FixedJoystick _joystick;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _rigidBody.velocity = new Vector2(_joystick.Horizontal * _moveSpeed, _joystick.Vertical * _moveSpeed);
    }
}
