using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class w2 : MonoBehaviour
{
    public static w2 instance=null;
    int sceneIndex;
    int lvc;



    // Start is called before the first frame update
    void Start()
        
    {
        if(instance==null)
        {
            instance = this;
        }
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        lvc = PlayerPrefs.GetInt("lvc");
    }

    public void isEndGame()
    {
        if (sceneIndex == 3)
        {
            Invoke("LoadMenu", 1f);
        }
        else
        {
            if (lvc < sceneIndex)
                PlayerPrefs.SetInt("lvc", sceneIndex);
            Invoke("w3", 1f);
        }
    }

    void w3()
    {
        SceneManager.LoadScene(sceneIndex + 1);
    }
    void LoadManu()
    {
        SceneManager.LoadScene("menu");
    }


 
}
