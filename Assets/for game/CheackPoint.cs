using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheackPoint : MonoBehaviour

{
    void Start()
    {
        if (PlayerPrefs.GetInt("PositionPlayer") == 1)
        {
            transform.position = new Vector2(PlayerPrefs.GetFloat("xPosition"), PlayerPrefs.GetFloat("yPosition"));
        }
        else if (PlayerPrefs.GetInt("PositionPlayer") == 0)
        {
            transform.position = new Vector2(-11.405f, -7.9457f);
        }

        if (PlayerPrefs.GetInt("PositionPlayer") == 2)
        {
            transform.position = new Vector2(PlayerPrefs.GetFloat("xPosition"), PlayerPrefs.GetFloat("yPosition"));
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("cheackpoint"))
        {
            PlayerPrefs.SetInt("PositionPlayer", 1);
            PlayerPrefs.SetFloat("xPosition", transform.position.x);
            PlayerPrefs.SetFloat("yPosition", transform.position.y);
        }

        if (collision.CompareTag("cheackpoint2"))
        {
            PlayerPrefs.SetInt("PositionPlayer", 2);
            PlayerPrefs.SetFloat("xPosition", transform.position.x);
            PlayerPrefs.SetFloat("yPosition", transform.position.y);
        }
    }

    public void Reset()
    {
        PlayerPrefs.SetInt("PositionPlayer", 0);
    }
}
