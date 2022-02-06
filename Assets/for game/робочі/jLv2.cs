using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jLv2 : MonoBehaviour
{





    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "lastFinish")
        {
            SceneManager.LoadScene(4);
        }
    }
}
