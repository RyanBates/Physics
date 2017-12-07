using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpringDamperBehaviour : MonoBehaviour
{
    ClothSize cloth;
    HooksLaw.SpringDamper Sd;

    HooksLaw.Particle p1;
    HooksLaw.Particle p2;

    public List<ParticleBehaviour> particles;
    public List<HooksLaw.SpringDamper> springDampers;

    void UpdateParticles(HooksLaw.Particle part1, HooksLaw.Particle part2)
    {
        Sd = new HooksLaw.SpringDamper(part1, part2, 5, .7f, 10);
        springDampers.Add(Sd);
    }

    void Start()
    {
        for (int i = 0; i < particles.Count - 1; i++)
        {
            p1 = particles[i].particle;
            p2 = particles[i + 1].particle;

            if (!(i != 0) && (i + 1) % cloth.size == 0)
                UpdateParticles(p1, p2);
        }

        for (int i = 0; i <= particles.Count - 1; i++)
        {
            p1 = particles[i].particle;
            p2 = particles[i + (int)cloth.size - 1].particle;

            UpdateParticles(p1, p2);
        }
    }

    void Update()
    {
        foreach (HooksLaw.SpringDamper s in springDampers)
        {
            Sd.CalculateForce();
        }
    }
}