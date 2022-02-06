using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Menu : MonoBehaviour
{
    public static float score;
    //[SerializeField] private TMP_Text coinsText;
    private void Start()
    {
        score = 0;
        //  int coins = PlayerPrefs.GetInt("coin");
        //coinsText.text = coins.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void Quite()
    {
        Application.Quit();
    }
    public void Lv()
    {
        SceneManager.LoadScene(3);
    }
    public void Lv1()
    {
        SceneManager.LoadScene(1);
        score = 0;
    }
    public void Lv2()
    {
        SceneManager.LoadScene(2);
    }
    public void menu1Lv()
    {
        SceneManager.LoadScene(0);
    }
    public void l6()
    {
        SceneManager.LoadScene(6);
    }
    public void l7()
    {
        SceneManager.LoadScene(7);
    }
    public void l5()
    {
        SceneManager.LoadScene(5);
    }
    public void l8()
    {
        SceneManager.LoadScene(8);
    }
    public void l4()
    {
        SceneManager.LoadScene(4);
    }
}
