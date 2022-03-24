//! DEVELOPMENT


using System.Collections;
using System.Collections.Generic;
using UnityEngine;


 //! PRODUCTION


 
public class PlayerMovement : MonoBehaviour{


public float moveSpeed;

public Rigidbody2D rb;

// Animation controls start
Animator animator;

Vector2 movement;


   

 void Start() {
     animator = GetComponent<Animator>();
 }


    void Update()
    {
        MovementInput();
    }

    private void FixedUpdate() {
        rb.velocity = movement * moveSpeed;

    }

    void MovementInput() {
        float mx = Input.GetAxisRaw("Horizontal");
        float my = Input.GetAxisRaw("Vertical");
        
        movement = new Vector2(mx, my).normalized;

    }
}
