using UnityEngine;

public class CustomPhysicsBody : MonoBehaviour
{
    public float mass = 1f;
    public float gravity = 9.81f;

    private Vector3 velocity;

    private void FixedUpdate()
    {
        Vector3 force = Vector3.down * mass * gravity;

        Vector3 acceleration = force / mass;

        velocity += acceleration * Time.fixedDeltaTime;

        transform.position += velocity * Time.fixedDeltaTime;
    }
}
