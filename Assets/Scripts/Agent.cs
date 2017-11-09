using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Ryan
{
    [CreateAssetMenu]
    public abstract class Agent : ScriptableObject
    {
        public float mass, acceleration, max_speed;

        public Vector3 seperation, alignment, cohesion;

        public Vector3 velocity, position;

        public abstract Vector3 Update_Agent();

        public abstract bool AddForce(float a, Vector3 b);
    }
}