using UnityEngine;

public class Coin : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player_2"))
        {
            Destroy(this.gameObject);
        }

        if (other.gameObject.CompareTag("Player_1"))
        {
            Destroy(this.gameObject);
        }
    }
}
