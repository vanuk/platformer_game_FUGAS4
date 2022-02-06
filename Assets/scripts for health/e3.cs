using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class e3 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            h3.health -= 1;
        }
    }
}
