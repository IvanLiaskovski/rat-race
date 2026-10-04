using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    public Transform spawnPoint;
    public float deathHeight = -10f;

    void Update()
    {
        if (transform.position.y < deathHeight)
        {
            Respawn();
        }
    }

    void Respawn()
    {
        transform.position = spawnPoint.position;
        transform.rotation = spawnPoint.rotation;

        Rigidbody rb = GetComponent<Rigidbody>();

        if (rb != null)
        {
            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }

    public void SetCheckpoint(Transform newSpawnPoint)
    {
        spawnPoint = newSpawnPoint;
    }
}
