using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentFactory : MonoBehaviour
{
    static public List<Ryan.Agent> agents;

    static public List<Boid> GetBoids(List<Boid> results)
    {
        foreach (Boid B in agents)
            results.Add(B);

        return results;
    }

    public void Initialize(int count)
    {
        for (int i = 0; i <= count; i++)
        {
            var go = new GameObject();

            var bb = go.AddComponent<BoidBehaviour>();

            var boid = ScriptableObject.CreateInstance<Boid>();

            agents.Add(boid);

            bb.SetMoveable(boid);
        }
    }
}