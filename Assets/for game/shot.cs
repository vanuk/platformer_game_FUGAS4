using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot : MonoBehaviour

{

    bool faceRight;
    public Transform shotpos;
    public GameObject Bullet;
    void Start()
    {

    }

    // Update is called once per frame
   public void Shot()
    {
  
        
            Instantiate(Bullet, shotpos.transform.position, transform.rotation);
        
    }
}