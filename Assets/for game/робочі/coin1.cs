using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin1 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "coins")
        {
            Destroy(coll.gameObject);
        }
    }
}