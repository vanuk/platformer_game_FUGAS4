using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour
{



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            magscore.score += 1;
            Destroy(gameObject);
        }
    }
}


