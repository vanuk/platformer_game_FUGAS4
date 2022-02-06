using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
   public void Button_pause()
    {
        if (Time.timeScale != 0) Time.timeScale = 0;
        else Time.timeScale = 1;    
    }
}
