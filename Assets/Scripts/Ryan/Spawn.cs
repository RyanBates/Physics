using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject agent;

    AgentFactory AF;

    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            var go = Instantiate(agent, 
                new Vector3(Random.Range(-15, 15),
                Random.Range(-15, 15), 
                Random.Range(-15, 15)), 
                Quaternion.identity);

            var bb = go.AddComponent<BoidBehaviour>();

            var boid = ScriptableObject.CreateInstance<Boid>();

            AF.agents.Add(boid);

            bb.SetMoveable(boid);
        }
    }
}