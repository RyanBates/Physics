using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Wind
{
    public class WindForce
    {
        HooksLaw.Particle p1, p2, p3;
        public float drag = 1;
        public float density = 1;

        public void CalculateWind(Vector3 wind)
        {
            Vector3 v = (p1.velocity + p2.velocity + p3.velocity) / 3 - wind;

            Vector3 n = Vector3.Cross((p2.position - p1.position), (p3.position - p1.position).normalized);

            float ao = n.magnitude;

            float a = ao * Vector3.Dot(v, n) / v.magnitude;

            Vector3 f = (density / -2) * (v.magnitude * v.magnitude) * drag * a * n;

            p1.AddForce(f / 3);
            p2.AddForce(f / 3);
            p3.AddForce(f / 3);
        }
    }

    class Triangles
    {
        HooksLaw.Particle p1, p2, p3;

        void TriangleCollider()
        {
            Vector3 c = (p1.position + p2.position + p3.position) / 3;
            Vector3 av = (p1.velocity + p2.velocity + p3.velocity) / 3;


        }

    }
}