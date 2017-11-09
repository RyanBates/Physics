using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoidBehavoiur : AgentBehaviour
{
    protected Ryan.Agent agent;

    Vector3 Cohesion(BoidBehavoiur bj)
    {
        Vector3 pc;

        foreach (BoidBehavoiur b in agentBehaviour)
            if (b != bj)
                pc = b.transform.position;

        

        return (pc - bj.agent.position) / 100;
    }

    Vector3 Seperation(BoidBehavoiur bj)
    {
        Vector3 c;

        foreach (BoidBehavoiur b in agentBehaviour)
            if (b != bj)
                if (b.agent.position - bj.agent.position < 100)
                    c = c - (b.agent.position - bj.agent.position);

        return c;
    }

    Vector3 Alignment(BoidBehavoiur bj)
    {
        Vector3 pv;


        foreach (BoidBehavoiur b in agentBehaviour)
            if (b != bj)
                pv = pv + b.agent.velocity;

        return (pv - bj.agent.velocity) / 8;
    }
    
    void Move()
    {

    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void LateUpdate()
    {
        
    }
}