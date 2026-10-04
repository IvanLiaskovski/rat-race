using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    public float speed = 2f;
    public float distance = 5f;
    Vector3 start;

    void Start() => start = transform.position;

    void Update()
    {
        transform.position = start + Vector3.right * Mathf.PingPong(Time.time * speed, distance);
    }
}
