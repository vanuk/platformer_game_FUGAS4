using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class w1 : MonoBehaviour
{
    public Button lv1;
    public Button lv2;
    int lvc;



    // Start is called before the first frame update
    void Start()
    {
        lvc = PlayerPrefs.GetInt("levelc");
        lv1.interactable = false;
        lv2.interactable = false;

        switch (lvc)
        {
            case 1:
                lv1.interactable = true;
                break;
            case 2:
                lv1.interactable = true;
                lv2.interactable = true;
                break;
        }
    }
    public void LoadTo(int level)
    {
        SceneManager.LoadScene(level);
    }


    public void Reset()
    {
        lv1.interactable = false;
        lv2.interactable = false;
        PlayerPrefs.DeleteAll();

    }
    // Update is called once per frame
}
