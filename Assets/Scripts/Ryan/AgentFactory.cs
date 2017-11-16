using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentFactory : MonoBehaviour
{
    public GameObject agent;    

    public List<Ryan.Agent> agents;
    
    public void Create(int count)
    {
        for (int i = 0; i <= count; ++i)
        {
            var go = Instantiate(agent,
                new Vector3(Random.Range(-15, 15),
                Random.Range(-15, 15),
                Random.Range(-15, 15)),
                Quaternion.identity);

            var bb = go.AddComponent<BoidBehaviour>();

            var boid = ScriptableObject.CreateInstance<Boid>();
            
            agents.Add(boid);

            bb.SetMoveable(boid);
        }
    }

    public List<Boid> GetBoids()
    {
        List<Boid> results = new List<Boid>();

        foreach (Boid B in agents)
            results.Add(B);

        return results;
    }

    private void Start()
    {
        GetBoids();
        Create(10);
      
    }
}