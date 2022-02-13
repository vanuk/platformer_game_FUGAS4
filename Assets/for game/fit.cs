using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fit : MonoBehaviour
{

    public int health;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            health -= 5;
        }
    }
}

