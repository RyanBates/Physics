using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothSpawn : MonoBehaviour
{
    public GameObject cloth;

    AgentBehaviour AB;

    // Use this for initialization
    void Start()
    {
        for (int i = 0; i <= 3; i++)
        {
            for (int j = 0; j <= 3; j++)
            {
                Instantiate(cloth, new Vector3(i * 2, j * 5 , 0), Quaternion.identity);
            }
        }
    }

	// Update is called once per frame
	void Update ()
    {
		
	}
}
