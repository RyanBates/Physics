using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour {

    float speed = .2f;
    public Vector3 pos;

	// Use this for initialization
	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = pos;

        if (Input.GetKey(KeyCode.A))
            pos.x -= speed;
        
        if (Input.GetKey(KeyCode.D))
            pos.x += speed;
        
    }
}
