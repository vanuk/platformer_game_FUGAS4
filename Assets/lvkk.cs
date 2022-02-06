using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lvkk : MonoBehaviour
{
   
        private void OnTriggerEnter2D(Collider2D coll)
        {
            if (coll.tag == "lvk1")
            {
                SceneManager.LoadScene(4);
            }
        }
    
}

