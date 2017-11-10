using UnityEngine;

public interface IFlockable
{
    Vector3 Dispersion(Boid b);
    Vector3 Alignment(Boid b);
    Vector3 Cohesion(Boid b);
}

public class FlockBehaviour : BoidBehaviour//, IFlockable
{
    Ryan.Agent agent;
    BoidBehaviour BB;

    //public Vector3 Cohesion(Boid b)
    //{
    //    foreach (Boid B in AB.agentBehaviour)
    //        if (b != B)
    //        {
    //            b.cohesion = b.cohesion + b.position;
    //            BB.SetAgent(b);
    //        }
    //    return (b.cohesion - b.position) / 100;
    //}

    //public Vector3 Dispersion(Boid b)
    //{
    //    foreach (Boid B in AB.agentBehaviour)
    //        if (b.position.x - B.position.x < 1 || b.position.y - B.position.y < 1 || b.position.z - B.position.z < 1)
    //        {
    //            b.seperation = b.seperation - (b.position - B.position);
    //            BB.SetAgent(b);
    //        }
    //    return b.seperation;
    //}

    //public Vector3 Alignment(Boid b)
    //{
    //    foreach (Boid B in AB.agentBehaviour)
    //        if (b != B)
    //        {
    //            b.alignment = b.alignment + b.velocity;
    //            BB.SetAgent(b);
    //        }

    //    return (b.alignment - b.velocity) / 8;
    //}

    //void Update()
    //{
    //    Vector3 v1, v2, v3;

    //    foreach (Boid b in AB.agentBehaviour)
    //    {
    //        BB.SetAgent(b);

    //        v1 = Cohesion(b);
    //        v2 = Dispersion(b);
    //        v3 = Alignment(b);

    //        b.velocity = b.velocity + v1 + v2 + v3;
    //        b.position = b.position + b.velocity;
    //    }
    //}
}