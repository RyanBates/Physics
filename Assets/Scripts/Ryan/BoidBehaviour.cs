using UnityEngine;

public class BoidBehaviour : MonoBehaviour
{
    protected AgentBehaviour AB;
    protected Boid b;

    public void SetAgent(Boid b)
    {
        AB.agent = b;
        ((Boid)AB.agent).Initialize(10);
    }
    
    private void LateUpdate()
    {
        transform.position = AB.agent.Update_Agent(Time.deltaTime);
    }
}