using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class qwew : MonoBehaviour
{
    Text text;
    public static int BulletPlus = 5;
    void Start()
    {
        text = GetComponent<Text>();
        BulletPlus = 5;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = BulletPlus.ToString();
    }
}
