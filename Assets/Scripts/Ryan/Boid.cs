using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Boid : Ryan.Agent
{
    public override bool AddForce(float a, Vector3 b)
    {
        return AddForce(2, new Vector3(1, 0, 1));
    }

    public override Vector3 Update_Agent(float deltaTime)
    {
        return Update_Agent(deltaTime);
    }

    public void Initialize(int count)
    {
        for(int i = 0; i <= count; i++)
        {
            var go = new GameObject();
            
            Instantiate(go, go.transform.position, Quaternion.identity, go.transform);

        }
    }
}
    

