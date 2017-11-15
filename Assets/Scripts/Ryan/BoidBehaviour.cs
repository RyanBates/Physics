using System.Collections.Generic;
using UnityEngine;

public class BoidBehaviour : AgentBehaviour
{
    IMoveable moveable;

    public void SetMoveable(IMoveable mover)
    {
        moveable = mover;
    }

    private void LateUpdate()
    {
        transform.position = moveable.Update_Agent(Time.deltaTime);
    }
}