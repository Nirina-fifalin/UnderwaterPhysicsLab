using UnityEngine;

public class CustomPhysicsBody : MonoBehaviour
{
    public float mass = 1f;
    public float gravity = 9.81f;
    public float airDrag = 0.1f;

    private Vector3 velocity;

    private void FixedUpdate()
    {
        if (transform.position.y < -10f)
        {
            transform.position = new Vector3(0f, 5f, 0f);
            velocity = Vector3.zero;
        }

        Vector3 force = Vector3.down * mass * gravity;

        Vector3 dragForce = -velocity * airDrag;

        force += dragForce;

        Vector3 acceleration = force / mass;

        velocity += acceleration * Time.fixedDeltaTime;

        transform.position += velocity * Time.fixedDeltaTime;

        Debug.Log(
            $"Time: {Time.time:F2}s | " +
            $"Position Y: {transform.position.y:F2}m | " +
            $"Velocity Y: {velocity.y:F2}m/s | " +
            $"Acceleration Y: {acceleration.y:F2}m/s²"
        );
    }
}
