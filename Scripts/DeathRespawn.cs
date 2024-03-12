using UnityEngine;

public class DeathRespawn : MonoBehaviour
{
    public Transform spawnPoint; // Reference to the spawn point

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the player has collided with a GameObject tagged as "Cube"
        if (collision.gameObject.CompareTag("Cube"))
        {
            // Respawn the player at the spawn point
            transform.position = spawnPoint.position;
        }
    }
}