using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restyrt : MonoBehaviour
{
    public static float score;
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "DeathCollider")
        {
            SceneManager.LoadScene(1);
            score = 0;
        }
    }
}
