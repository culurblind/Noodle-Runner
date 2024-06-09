using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody2D body;
    public BoxCollider2D groundCheck;
    public LayerMask groundMask;

    public float acceleration;
    public float groundSpeed;
    public float jumpSpeed;
    [Range(0f, 0.9f)]
    public float groundDecay;
    public bool grounded;

    float xInput;
    float yInput;

    void Start() {


    }
    

    void Update(){


        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");

        if (Math.Abs(xInput) > 0) {

            //float increment = xInput * acceleration;
            //float newSpeed = Mathf.Clamp(body.velocity.x + increment, -groundSpeed, groundSpeed);
            body.velocity = new Vector2(xInput * groundSpeed, body.velocity.y);

            //float direction = Mathf.Sign(xInput);
            //transform.localScale = new Vector3(direction, 1, 1);
        }

        if (Input.GetButtonDown("Jump") && grounded) {
            body.velocity = new Vector2(body.velocity.x, jumpSpeed);
        }

    }

    /*void getInput() {
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");
    }

    void MoveWInput() { 
        if (Math.Abs(xInput) > 0) {
            body.velocity = new Vector2(xInput * speed, body.velocity.y);
        }

        if (Math.Abs(yInput) > 0) {
            body.velocity = new Vector2(body.velocity.x, yInput * speed);
        }
    }*/

    void FixedUpdate() {
        CheckGround();

        if (Math.Abs(xInput) > 0) {
            body.velocity = new Vector2(xInput * groundSpeed, body.velocity.y);
        }

        if (grounded && xInput == 0 && yInput == 0) {
            body.velocity *= groundDecay;
        }

        Friction();
    }

    void Friction() { 
        if (grounded && xInput == 0 && body.velocity.y <= 0) {
            body.velocity *= groundDecay;
        }
    }

     void CheckGround() {
        grounded = Physics2D.OverlapAreaAll(groundCheck.bounds.min, groundCheck.bounds.max, groundMask).Length > 0;
    }
}
