using UnityEngine.SceneManagement;
using UnityEngine;

public class game : MonoBehaviour
{
    public static bool isGameOver;
    public GameObject gameOverScreen;
    public static Vector2 lastCheckPointPos=new Vector2(-11,-8);
    // Start is called before the first frame update
    void Awake()
    { 
        isGameOver = false;
     
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
        {
            gameOverScreen.SetActive(true);
        }
    }
    public void ReplayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
