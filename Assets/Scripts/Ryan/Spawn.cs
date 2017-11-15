using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : FlockBehaviour
{
    public GameObject Target;
    public GameObject Agent;

    FlockBehaviour flock;

	void Update ()
    { 
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(Agent, new Vector3(Target.transform.position.x + 2, Target.transform.position.y + 2, Target.transform.position.z + 2), Quaternion.identity, Target.transform);
        }
    }
}