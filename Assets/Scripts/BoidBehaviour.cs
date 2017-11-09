using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoidBehaviour : AgentBehaviour
{
    protected Ryan.Agent agent;

    AgentBehaviour AB;

    Vector3 Cohesion(Boid bj)
    {
        foreach (BoidBehaviour b in AB.agentBehaviour)
            if (b != bj)
            {
                agent.cohesion = agent.cohesion - b.agent.position;
                AB.agentBehaviour.Add(b);
            }

        return (agent.cohesion - bj.agent.position);
    }

    Vector3 Seperation(Boid bj)
    {
        foreach (BoidBehaviour b in AB.agentBehaviour)
            if (b != bj)
                if (b.agent.position == bj.agent.position)
                {
                    agent.seperation = agent.seperation - (b.agent.position - bj.agent.position);
                    AB.agentBehaviour.Add(b);
                }

        return agent.seperation;
    }

    Vector3 Alignment(Boid bj)
    {
        foreach (BoidBehaviour b in AB.agentBehaviour)
            if (b != bj)
            {
                agent.alignment = agent.alignment + b.agent.velocity;
                AB.agentBehaviour.Add(b);
            }

        return (agent.alignment - bj.agent.velocity);
    }
    
    void Update()
    {
        Vector3 v1, v2, v3;

        foreach(BoidBehaviour b in AB.agentBehaviour)
        {
            Boid B = new Boid();

            v1 = Cohesion(B);
            v2 = Seperation(B);
            v3 = Alignment(B);

            B.agent.velocity = b.agent.velocity + v1 + v2 + v3;
            B.agent.position = b.agent.position + b.agent.velocity;

            Instantiate(B);

        }   
    }
}