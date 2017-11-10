using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AgentBehaviour : Boid
{
    public Ryan.Agent agent;
    public List<GameObject> agentBehaviour;

    public void Create()
    {
        agentBehaviour = new List<GameObject>();
    }
    
    public void Destory()
    {
        agentBehaviour.Clear();
    }
}
