using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class po1 : MonoBehaviour

{
    public int currentLife;
    public GameObject spawn;
    public GameObject checkpoint;
    private bool _checkpointActivated = false;
    void Start()
    {
        currentLife = 3;
        transform.position = spawn.transform.position;
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("DeathCollider1"))
        {
            currentLife--;
            if (!_checkpointActivated)
                transform.position = spawn.transform.position;
            else
                transform.position = checkpoint.transform.position;
        }

        if (col.gameObject.CompareTag("Checkpoint1"))
        {
            _checkpointActivated = true;
        }
    }


}