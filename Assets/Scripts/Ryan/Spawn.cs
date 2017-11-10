using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : FlockBehaviour
{
    public GameObject Target;
    public GameObject Agent;
    Ryan.Agent age;
    AgentBehaviour AB;

    public float mass, acceleration, max_speed;

    // Use this for initialization
 //   void Start ()
 //   {
 //       mass = age.mass;
 //       acceleration = age.acceleration;
 //       max_speed = age.max_speed;

 //       age.position = transform.position;
 //	}
	
	// Update is called once per frame
	void Update ()
    { 
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(Agent, new Vector3(Target.transform.position.x + 2, Target.transform.position.y + 2, Target.transform.position.z + 2), Quaternion.identity, Target.transform);
        }
    }
}