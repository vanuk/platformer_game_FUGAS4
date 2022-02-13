using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim : MonoBehaviour
{
    private Animator anim1;
    private void Start()
    {
        anim1 = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            anim1.SetBool("isruning", true);

        }
        else
        {
            anim1.SetBool("isruning", false);
        }
    }
}
