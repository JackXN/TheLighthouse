using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehavior {
public float moveSpeed;

public Rigidbody2D rb;

Vector2 movement;

void Update() {
    MovementInput();
}

private void FixedUpdate() {
    rb.velocity = movement * moveSpeed;
}


}
