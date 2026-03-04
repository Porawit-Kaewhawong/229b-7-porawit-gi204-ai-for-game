using UnityEngine;

public class SmoothPingPong : MonoBehaviour
{
    public Vector3 moveDirection = Vector3.right; // Direction of movement
    public float distance = 3f;                   // How far it moves
    public float speed = 2f;                      // Movement speed

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float movement = Mathf.PingPong(Time.time * speed, distance);
        transform.position = startPosition + moveDirection.normalized * movement;
    }
}