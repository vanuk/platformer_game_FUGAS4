using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dont : MonoBehaviour
{
    float speed = 5.0f;

    Rigidbody rb;

    bool FacingRight = true;

    int directionInput;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity= new Vector2(speed*directionInput,rb.velocity.y);

        if (directionInput < 0 && FacingRight)
        {
            Flip();
        }
        else if (directionInput > 0 && !FacingRight)
        {
            Flip();
        }

    }
    public void Move(int inputAxit)
    {
        directionInput = inputAxit;
    }
    void Flip()
    {
        FacingRight = !FacingRight;
        Vector3 theScale=transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
