using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class w3 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        w2.instance.isEndGame();
    }
}
