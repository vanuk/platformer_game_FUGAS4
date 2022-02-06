using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseA : MonoBehaviour
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

    public void PauseOff()
    {
        pause.SetActive(false);
        Time.timeScale = 1;
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}

