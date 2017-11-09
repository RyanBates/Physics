using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AgentBehaviour : Boid
{
    public Ryan.Agent agent;
    public List<AgentBehaviour> agentBehaviour;

    public void Create()
    {
        agentBehaviour = new List<AgentBehaviour>();
    }
    
    public void Destory()
    {
        agentBehaviour.Clear();
    }
}
