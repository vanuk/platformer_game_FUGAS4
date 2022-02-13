using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zzz : MonoBehaviour
{
    [SerializeField] public int speed;
    [SerializeField] private int jump;
    private bool ground;
    private Animator anim;
    private Rigidbody2D rb;
    [SerializeField] private Joystick joystick;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "ground")
            ground = true;
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "ground")
            ground = false;
    }
    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(joystick.Horizontal * speed, rb.velocity.y);
        if (joystick.Horizontal != 0)
        {
            anim.SetBool("Walk", true);
        }
        else if (joystick.Horizontal == 0)
        {
            anim.SetBool("Walk", false);
        }
        if (joystick.Vertical >= 1.0f)
        {
            Jump();
        }
    }
    private void Jump()
    {
        if (ground == true)
        {
            rb.AddForce(transform.up * jump, ForceMode2D.Impulse);
            anim.SetTrigger("Jump");
        }
    }
   
}
