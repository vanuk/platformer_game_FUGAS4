using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rye : MonoBehaviour
{
    public Joystick joystick;
    private float inputVertical;
    public float speed;
    Rigidbody2D rb;
    public float distance;
    public LayerMask whatisLadder;
    private bool Climbing;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float verticalMove = joystick.Vertical;
        RaycastHit2D hitinfo = Physics2D.Raycast(transform.position, Vector2.up, distance, whatisLadder);

        if (hitinfo.collider != null)
        {
            if (verticalMove>=0.5)
            {
                Climbing = true;
            }
        }
        else
        {
            Climbing = false;
        }

        if (Climbing == true && hitinfo.collider != null)
        {
            inputVertical = joystick.Horizontal;
            rb.velocity = new Vector2(rb.position.x, inputVertical * speed);
            rb.gravityScale = 0;
        }
        else
        {
            rb.gravityScale = 5;
        }
    }
}
