using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class en: MonoBehaviour
{
    public float speed;
    public float distance;
    private bool movingRight = true;
    public Transform groundcheak;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        RaycastHit2D groundinfo = Physics2D.Raycast(groundcheak.position, Vector2.down, distance);
        if (groundinfo.collider == false)
        {
            if (movingRight == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;
            }
        }
    }
}
