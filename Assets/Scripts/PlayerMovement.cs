using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5;

    public Rigidbody2D rb;

    Vector2 movement;

    // Update is called once per frame
    void Update() {
        MovementInput();
    }

    void FixedUpdate() {
        rb.velocity = movement * moveSpeed;
    }

    void MovementInput () {
        float mx = Input.GetAxisRaw("Horizontal");
        float my = Input.GetAxisRaw("Vertical");

        movement = new Vector2(mx, my).normalized;
    }
}
