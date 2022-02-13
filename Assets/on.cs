using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class on : MonoBehaviour
{
    [SerializeField]
    GameObject bullet;
    float fireRate;
    float nextFire;
    void Start()
    {
        fireRate = 1f;
        nextFire = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        CheakifTimeToFire();
    }


    void CheakifTimeToFire()
    {
        if (Time.time > nextFire)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            nextFire = Time.time + fireRate;
        }
    }
}