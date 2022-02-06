using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class android : MonoBehaviour
{
    [SerializeField] private int speed;
    [SerializeField] private int jump;
    private bool ground;
    private Animator anim;
    private Rigidbody rb;
    [SerializeField] private int direction;


    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        rb.velocity=new Vector2(direction*speed,rb.velocity.y);
        if (direction != 0)
            anim.SetBool("Walk", true);
        else if (direction == 0)
            anim.SetBool("Walk", false);
        Flip();
    }
    public void Jump()
    {
        if(ground==true)
        {
            rb.AddForce (transform.up * jump);
            anim.SetTrigger("Jump");
        }
    }
    public void  ChangeDirection(int buttonDirection)
    {
        direction = buttonDirection;
    }
    private void Flip()
    {
        if (direction > 0)
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        else if (direction < 0)
            transform.localRotation = Quaternion.Euler(0, 0, 0);

    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.tag=="ground")
            ground = true;
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "ground")
            ground = false;
    }
}
