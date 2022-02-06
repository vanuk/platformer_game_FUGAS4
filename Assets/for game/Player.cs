using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Player : MonoBehaviour
{
    public float speed;
    private float moveInput;
    private Rigidbody2D rb;
    public bool faceRight = true;

    public int gravityScale = 1;
    public int fallingGravityScale = 10;
    public float Jumpforce;
    private bool isGround;
    public Transform groundCheak;
    private int ExtraJump;
    public int extraJumpValue;
    public float cheakRadius;
    public LayerMask WhatIsGround;
    Animator anim;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(rb.velocity.y >= 0)
        {
            rb.gravityScale = gravityScale;
        }
        if (rb.velocity.y < 0)
        {
            rb.gravityScale = fallingGravityScale;
        }
        if (isGround == true)
        {
            ExtraJump = extraJumpValue;
        }

        if (Input.GetKeyDown(KeyCode.Space) && ExtraJump > 0)
        {
            rb.AddForce(Vector2.up * Jumpforce, ForceMode2D.Impulse);
            ExtraJump--;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && ExtraJump == 0 && isGround == true)
        {
            rb.AddForce(Vector2.up * Jumpforce, ForceMode2D.Impulse);
        }
    }
    private void FixedUpdate()
    {
        isGround = Physics2D.OverlapCircle(groundCheak.position, cheakRadius, WhatIsGround);

        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        if (faceRight == false && moveInput > 0)
        {
            Flip();
        }

        if (faceRight == true && moveInput < 0)
        {
            Flip();
        }

    }
    void Flip()
    {
        faceRight = !faceRight;

        transform.Rotate(0f, 180f, 0f);
    }
}


