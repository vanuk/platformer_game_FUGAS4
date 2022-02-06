using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class run : MonoBehaviour



{
    //run
    public float speed;
    public float jumpForce;
    private float moveInput;
    //mirror run
    private Rigidbody2D rb;
    private bool facingRight = true;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {



        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        if (facingRight == false && moveInput > 0)
        {
            Flip();

        }
        else if (facingRight == true && moveInput < 0)
        {
            Flip();
        }
    }
   
    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }

}

