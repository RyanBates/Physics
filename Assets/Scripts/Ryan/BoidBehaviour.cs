using UnityEngine;

public class BoidBehaviour : MonoBehaviour
{
    AgentBehaviour AB;

    public void SetAgent(Boid b)
    {
        AB.agent = b;
        ((Boid)AB.agent).Initialize();
    }

    private void LateUpdate()
    {
        transform.position = AB.agent.Update_Agent(Time.deltaTime);
    }
}