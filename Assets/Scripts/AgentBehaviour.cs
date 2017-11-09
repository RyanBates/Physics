using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AgentBehaviour : MonoBehaviour
{
    Ryan.Agent agent;

    public List<Ryan.Agent> agents;
    public List<AgentBehaviour> agentBehaviour;


    [ContextMenu("Create")]
    public void Create()
    {
        agents = new List<Ryan.Agent>();
        agentBehaviour = new List<AgentBehaviour>();        
    }


    [ContextMenu("Destory")]
    public void Destory()
    {
        agents.Clear();
        agentBehaviour.Clear();
    }
}
