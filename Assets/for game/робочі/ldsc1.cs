using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ldsc1 : MonoBehaviour
{

    public int _coinsPickedUp;
    // Start is called before the first frame update
    void Start()
    {
       // _coinsPickedUp = PlayerPrefs.GetInt(key: "Score");
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("coin"))
        {
            coll.gameObject.SetActive(false);
            ++_coinsPickedUp;
        }
       // if (coll.gameObject.CompareTag("Finish"))
       // {
         //   PlayerPrefs.SetInt("Score", _coinsPickedUp);
       // }
    }
}


