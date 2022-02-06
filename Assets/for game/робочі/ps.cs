using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ps : MonoBehaviour
{
    [SerializeField]
    GameObject pause;
    void Start()
    {
        pause.SetActive(false);
    }


    public void PauseOn()
    {
        pause.SetActive(true);
        Time.timeScale = 0;

    }
}