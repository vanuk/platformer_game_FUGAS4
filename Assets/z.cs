using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class z : MonoBehaviour
{
    public List<Text> recordStrings;
    void Start()
    {

        for (int i = 0; i < 10; i++)
        {
            if (PlayerPrefs.HasKey($"Score{i}") && PlayerPrefs.HasKey($"Score{i}"))
            {
                recordStrings[i].text = $"{PlayerPrefs.GetString($"playerName{i}")} - {PlayerPrefs.GetInt($"Score{i}")} points";
            }
        }
    }
}
