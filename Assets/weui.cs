using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weui : MonoBehaviour

{
    public Transform shotpos;
    public GameObject Bullet;
    public GameObject reserch;
    int howshot = 0;

    [SerializeField]
    private float cooldowntime = 0;
    private float nextfire = 0;
    void Start()
    {
        howshot = 0;
        reserch.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (howshot == 500)
        {
            StartCoroutine(reserchGun());
        }
    }

    public void Shot()
    {
        if (Time.time > nextfire)
        {
            if (howshot < 500)
            {
                Instantiate(Bullet, shotpos.transform.position, transform.rotation);
                howshot += 1;
                nextfire = Time.time + cooldowntime;
            }
        }
    }


    IEnumerator reserchGun()
    {
        reserch.SetActive(true);
        yield return new WaitForSeconds(4);
        reserch.SetActive(false);
        howshot = 0;
    }
}

