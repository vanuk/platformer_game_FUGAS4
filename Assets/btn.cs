using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btn : MonoBehaviour
{
    private bool isLadder;
    private bool isClimbing;
    private Rigidbody2D rb;
    private bool moveLeft;
    private bool moveRight;
    private bool moveUp;
    private float horizontalMove;
    private float verticalMove;
    public float speed = 5;
    public float jumpSpeed = 5;
    public bool faceRight = true;
    private float moveInput;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        moveLeft = false;
        moveRight = false;
        moveUp = false;

    }

    //I am pressing the left button
    public void PointerDownLeft()
    {
        moveLeft = true;
    }

    //I am not pressing the left button
    public void PointerUpLeft()
    {
        moveLeft = false;
    }

    //Same thing with the right button
    public void PointerDownRight()
    {
        moveRight = true;
    }

    public void PointerUpRight()
    {
        moveRight = false;
    }
    public void PointerDownLeft1()
    {
        moveUp = true;
    }

    //I am not pressing the left button
    public void PointerUpLeft1()
    {
        moveUp = false;
    }

    // Update is called once per frame
    void Update()
    {
        MovementPlayer();
       
    }

    //Now let's add the code for moving
    private void MovementPlayer()
    {
        //If i press the left button
        if (moveLeft)
        {
            horizontalMove = -speed;
        }

        //if i press the right button
        else if (moveRight)
        {
            horizontalMove = speed;
        }

        //if i am not pressing any button
        else
        {
            horizontalMove = 0;
        }

        if (moveUp)
        {
            verticalMove = speed;
        }
        if (moveUp)
        {
            verticalMove = -speed;
        }
    }

    public void jumpButton()
    {
        if (rb.velocity.y == 0)
        {
            rb.velocity = Vector2.up * jumpSpeed;
        }
      
    }

    //add the movement force to the player
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontalMove, rb.velocity.y);
        if (faceRight == false && horizontalMove > 0)
        {
            Flip();
        }

        if (faceRight == true && horizontalMove < 0)
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
