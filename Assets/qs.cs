using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class qs : MonoBehaviour
{
    float moveSpeed = 7f;
    Rigidbody2D rb;
    mp target;
    Vector2 moveDirection;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindObjectOfType<mp>();
        moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
        Destroy(gameObject, 3f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
