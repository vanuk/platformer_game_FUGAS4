using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class e1 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            h1.health -= 1;
        }
    }
}
