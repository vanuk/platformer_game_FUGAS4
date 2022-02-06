using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wert : MonoBehaviour
{

    bool faceRight;
    public Transform shotpos;
    public GameObject Bullet;
    void Start()
    {

    }

    // Update is called once per frame
    public void Update()
    {
       // if (Input.GetKeyDown(KeyCode.F))
       // {
           Instantiate(Bullet, shotpos.transform.position, transform.rotation);
       // }
    }
}


