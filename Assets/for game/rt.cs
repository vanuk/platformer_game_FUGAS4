using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rt : MonoBehaviour

{
    [SerializeField]
    Transform shotpos;
    [SerializeField]
    GameObject Bullet;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) )
        {
            Instantiate(Bullet, shotpos.transform.position, transform.rotation);
           
        }
    }
}
