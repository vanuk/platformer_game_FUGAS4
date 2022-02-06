using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class e4 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            h4.health -= 1;
        }
    }
}
