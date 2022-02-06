
using UnityEngine;

public class teleport : MonoBehaviour
{
    public GameObject respawn;

    private void OnTriggerEnter2D(Collider2D other )
    {
        if (other.tag == "Player")
        {
            other.transform.position=respawn.transform.position;
        }
    }
}
