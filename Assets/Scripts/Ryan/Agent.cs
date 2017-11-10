using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Ryan
{
    public abstract class Agent : ScriptableObject
    {
        public float mass = 1, max_speed = 50;

        public Vector3 seperation, alignment, cohesion;

        public Vector3 acceleration, velocity, force, position;

        public abstract Vector3 Velocity();
    }
}