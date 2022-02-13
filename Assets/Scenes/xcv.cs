using UnityEngine;
using UnityEngine.SceneManagement;
public class xcv : MonoBehaviour
{ public void ButtonClicked()
    {
        if (PlayerPrefs.HasKey("lastLevel"))
        {

            SceneManager.LoadScene(PlayerPrefs.GetString("lastLevel"));
        }

        else
        {

            SceneManager.LoadScene(1);
        }
    } 
}