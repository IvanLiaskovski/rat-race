using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerRespawn player = other.GetComponent<PlayerRespawn>();

        if (player != null)
        {
            player.SetCheckpoint(transform);
        }
    }
}
