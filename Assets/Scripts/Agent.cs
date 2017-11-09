using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Ryan
{
    public abstract class Agent : ScriptableObject
    {
        public float mass = 1, acceleration = 0, max_speed = 50;

        public Vector3 seperation, alignment, cohesion;

        public Vector3 velocity, position;

        public abstract Vector3 Update_Agent();

        public abstract bool AddForce(float a, Vector3 b);
    }
}