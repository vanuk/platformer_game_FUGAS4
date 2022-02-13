using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class werw3 : MonoBehaviour
{
    
    [SerializeField]
    Transform player;

    [SerializeField]
    float agroRange;

    [SerializeField]
    float moveSpeed;

    Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float distToPlayer = Vector2.Distance(transform.position, player.position);

        if (distToPlayer < agroRange)
        {
            ChasePlayer();
        }
          else
        {
            StopChasePlayer();
        }
      
      
    }

    void ChasePlayer()
    {
        if (transform.position.x < player.position.x)
        {
            rb.velocity = new Vector2(moveSpeed, 0);
            GetComponent<SpriteRenderer>().flipX = false;
        }
        else
        {
            rb.velocity = new Vector2(-moveSpeed, 0);
            GetComponent<SpriteRenderer>().flipX = true;
        }
    }

    void StopChasePlayer()
    {
        rb.velocity = new Vector2(0, 0);
    }
}