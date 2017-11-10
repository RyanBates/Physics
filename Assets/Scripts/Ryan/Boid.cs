using UnityEngine;


public interface IMoveable
{
    Vector3 Update_Agent(float dt);
    bool AddForce(float a, Vector3 b);
}

[CreateAssetMenu]
public class Boid : Ryan.Agent, IMoveable
{
    Spawn s;
    public GameObject go;


    public Vector3 Update_Agent(float deltaTime)
    {
        acceleration = force / mass;
        velocity += acceleration * deltaTime;
        velocity = Vector3.ClampMagnitude(velocity, max_speed);
        position += velocity * deltaTime;

        return position;
    }

    public bool AddForce(float a, Vector3 b)
    {
        return AddForce(2, new Vector3(1, 0, 1));
    }

    public override Vector3 Velocity()
    {

        return velocity;
    }
}