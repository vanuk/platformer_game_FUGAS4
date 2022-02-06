using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tp : MonoBehaviour
{
    [SerializeField] Text HighScoreText;
    [SerializeField] Text ScoreText;

    public GameObject player;
    public static float score;
    int highscore;
    // Start is called before the first frame update
    void Start()
    {
        score=0;
        ScoreText.color = Color.yellow;
    }

    // Update is called once per frame
    void Update()
    {
      
        ScoreText.text = $"{player.GetComponent<coinnn>()._coinsPickedUp}";
       //HighScoreText.text = "HIGHSCORE: " + PlayerPrefs.GetInt("score").ToString();
    }
}
