using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlockBehaviour : MonoBehaviour
{
    AgentFactory AF;
    BoidBehaviour BB;

    //public Slider sCohesion;
    //public Slider sDispersion;
    //public Slider sAlignment;

    float kCohesion;
    float kDispersion;
    float kAlignment;

    public Vector3 Cohesion(Boid b)
    {
        foreach (Boid B in AF.agents)
            if (b != B)
            {
                b.cohesion = b.cohesion + b.position;
                BB.SetMoveable(b);
            }

        //kCohesion = ((b.cohesion.x - b.position.x) / 100) * ((b.cohesion.y - b.position.y) / 100) * ((b.cohesion.z - b.position.z) / 100);


        return (b.cohesion - b.position) / 100;
    }

    public Vector3 Dispersion(Boid b)
    {
        foreach (Boid B in AF.agents)
            if (b.position.x - B.position.x < 1 || b.position.y - B.position.y < 1 || b.position.z - B.position.z < 1)
            {
                b.seperation = b.seperation - (b.position - B.position);
                BB.SetMoveable(b);
            }

        //kDispersion = b.seperation.x + b.seperation.y + b.seperation.z;

        return b.seperation;
    }

    public Vector3 Alignment(Boid b)
    {
        foreach (Boid B in AF.agents)
            if (b != B)
            {
                b.alignment = b.alignment + b.velocity;
                BB.SetMoveable(b);
            }

        //kAlignment = ((b.alignment.x - b.velocity.x) / 8) * ((b.alignment.y - b.velocity.y) / 8) * ((b.alignment.z - b.velocity.z) / 8);
        
        return (b.alignment - b.velocity) / 8;
    }

    void Start()
    {

    }

    void Update()
    {
        Vector3 v1, v2, v3;

        foreach (Boid b in AF.agents)
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