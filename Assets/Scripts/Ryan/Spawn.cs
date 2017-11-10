using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : Center
{
    public GameObject Agent;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Instantiate(Agent, new Vector3(1+Input.mousePosition.x, 1+Input.mousePosition.y, 1+Input.mousePosition.z), Quaternion.identity, target.transform);
            AB.agentBehaviour.Add(Agent);
        }
    }
}
