using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class life : MonoBehaviour
{

    public Image healthbar;
    public Image healtBarEffect;
    float maxhealth = 100f;
    public static float health;

    private float healthspeed = 0.003f;



    void Start()
    {
        healthbar = GetComponent<Image>();
        health = maxhealth;
    }

    // Update is called once per frame
    void Update()
    {
        healthbar.fillAmount = health / maxhealth;
        if (healtBarEffect.fillAmount > healthbar.fillAmount)
        {
            healtBarEffect.fillAmount -= healthspeed;
        }
        else
        {
            healtBarEffect.fillAmount = healthbar.fillAmount;
        }
    }
}

