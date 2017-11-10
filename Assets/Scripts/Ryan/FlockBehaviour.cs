using System.Collections.Generic;
using UnityEngine;

public interface IFlockable
{
    Vector3 Dispersion(Boid b);
    Vector3 Alignment(Boid b);
    Vector3 Cohesion(Boid b);
}

public class FlockBehaviour : MonoBehaviour, IFlockable
{
    BoidBehaviour BB;

    List<Boid> Boids;


    float kCohesion;
    float kDispersion;
    float kAlignment;

    public Vector3 Cohesion(Boid b)
    {
        foreach (Boid B in Boids)
            if (b != B)
            {
                b.cohesion = b.cohesion + b.position;
                BB.SetMoveable(b);
            }
        return (b.cohesion - b.position) / 100;
    }

    public Vector3 Dispersion(Boid b)
    {
        foreach (Boid B in Boids)
            if (b.position.x - B.position.x < 1 || b.position.y - B.position.y < 1 || b.position.z - B.position.z < 1)
            {
                b.seperation = b.seperation - (b.position - B.position);
                BB.SetMoveable(b);
            }
        return b.seperation;
    }

    public Vector3 Alignment(Boid b)
    {
        foreach (Boid B in Boids)
            if (b != B)
            {
                b.alignment = b.alignment + b.velocity;
                BB.SetMoveable(b);
            }

        return (b.alignment - b.velocity) / 8;
    }

    void Start()
    {

    }

    void Update()
    {
        AgentFactory.GetBoids(Boids);

        Vector3 v1, v2, v3;

        foreach (Boid b in Boids)
        {
            BB.SetMoveable(b);

            v1 = Cohesion(b);
            v2 = Dispersion(b);
            v3 = Alignment(b);

            b.velocity = b.velocity + v1 + v2 + v3;
            b.position = b.position + b.velocity;
        }

    }
}