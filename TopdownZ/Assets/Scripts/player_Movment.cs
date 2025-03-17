using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingScript : MonoBehaviour
{
    public Rigidbody2D Player;
    public float WalkingSpeed = 8f;
    public float RunningSpeed = 10f;

    private float horizontal;
    private float vertical;
    private float Speed;

    private Vector2 movement;

    void Start()
    {
      
    }

    void Update()
    {
   
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

       
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Speed = RunningSpeed;
        }
        else
        {
            Speed = WalkingSpeed;
        }
    }

    private void FixedUpdate()
    {
       
        movement = new Vector2(horizontal, vertical).normalized;

      
        Player.velocity = movement * Speed;

       
        Debug.Log(Player.velocity);
        Debug.Log(movement);
    }
}
