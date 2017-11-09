using UnityEngine;

public interface IFlockable
{
    Vector3 Dispersion(Boid b);
    Vector3 Alignment(Boid b);
    Vector3 Cohesion(Boid b);
}

public class FlockBehaviour : MonoBehaviour, IFlockable
{
    Ryan.Agent agent;
    AgentBehaviour AB;

    public Vector3 Cohesion(Boid b)
    {
        foreach (Boid B in AB.agentBehaviour)
            if (b != B)
                b.cohesion = b.cohesion + b.position;

        return (b.cohesion - b.position) / 100;
    }

    public Vector3 Dispersion(Boid b)
    {
        foreach (Boid B in AB.agentBehaviour)
            if (b.position == B.position)
                b.seperation = b.seperation - (b.position - B.position);

        return b.seperation;
    }

    public Vector3 Alignment(Boid b)
    {
        foreach (Boid B in AB.agentBehaviour)
            if (b != B)
                b.alignment = b.alignment + b.velocity;

        return (b.alignment - b.velocity) / 8;
    }

    void Update()
    {
        Vector3 v1, v2, v3;

        foreach (Boid b in AB.agentBehaviour)
        {
            v1 = Cohesion(b);
            v2 = Dispersion(b);
            v3 = Alignment(b);

            b.velocity = b.velocity + v1 + v2 + v3;
            b.position = b.position + b.velocity;
        }

    }
}