using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public float moveSpeed = 5f;
    
    public Rigidbody2D rb;

    Vector2 movement; //stores an x and an y

    void Update()
    {
        //input
        movement.x = Input.GetAxisRaw("Horizontal"); // gives value -1 to 1 depending on input
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        //movement
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
