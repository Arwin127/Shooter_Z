using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class WalkingScript : MonoBehaviour
{

    public Rigidbody2D Player;
    public float WalkingSpeed = 8f;
    public float RunningSpeed = 10f;

    private float horizontal;
    private float vertical;
    private float Speed;

    private Vector3 movement;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
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

        movement = new Vector3(horizontal, vertical, 0).normalized;
        Player.velocity = new Vector3(movement.x * Speed, movement.y * Speed, movement.z * Speed);




        Debug.Log(Player.velocity);
        Debug.Log(movement);

    }
}