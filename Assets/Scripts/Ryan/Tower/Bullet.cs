using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Bullet : ScriptableObject
{
    [HideInInspector]
    public float displacement;
    [HideInInspector]
    public float time;

    public float intialVelocity;
    [HideInInspector]
    public float finalVelocity;

    public float constantAcceleration;


    public float FirstSolution()
    {
        finalVelocity = intialVelocity + constantAcceleration * time;

        return finalVelocity;
    }

    public float SecondSolution()
    {
        displacement = ((finalVelocity + intialVelocity) / 2) * time;

        return displacement;
    }

    public float ThirdSolution()
    {
        displacement = intialVelocity * time + .5f * constantAcceleration * (time * time);

        return displacement;
    }

    public float FourthSolution()
    {
        float finalVelocitySquared = intialVelocity * intialVelocity + 2 * constantAcceleration * displacement;

        return finalVelocitySquared;
    }

}
