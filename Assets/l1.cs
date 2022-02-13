using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class l1 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bullet"))
        {
            life.health -= 5;
        }
    }
}
