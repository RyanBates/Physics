﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringDamperBehaviour : MonoBehaviour
{
    public GameObject game;
    public float rows = 10;
    public float colms = 10;
    public float drag = 1;
    public float density = 1;

    public float constant, damping, rest;



    HooksLaw.Particle p1, p2, p3;

    HooksLaw.SpringDamper Sd;

    Wind.WindForce wind;

    public List<HooksLaw.Particle> particles;
    public List<HooksLaw.SpringDamper> springDampers;

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

    void Start()
    {

        for (int i = 0; i < rows; i++)
            for (int j = 0; j < colms; j++)
            {
                GameObject p = Instantiate(game, new Vector3(i * 2.5f, -j * 2.5f, 7), Quaternion.identity);
                p.AddComponent<ParticleBehaviour>();
                p.GetComponent<ParticleBehaviour>().particle = new HooksLaw.Particle(p.transform.position, Vector3.zero, 1);
                gameObject.GetComponent<SpringDamperBehaviour>().particles.Add(p.GetComponent<ParticleBehaviour>().particle);
            }

        for (int i = 0; i < colms * rows; i++)
        {
            if (i % colms < colms - 1)
            {
                p1 = particles[i];
                p2 = particles[i + 1];

                springDampers.Add(new HooksLaw.SpringDamper(p1, p2, constant, rest, damping));
                p1.gravity = true;
                p2.gravity = true;
                p1.anchor = true;
                p2.anchor = false;
            }

            if (i < (colms * rows) - colms)
            {
                p1 = particles[i];
                p2 = particles[i + (int)rows];

                springDampers.Add(new HooksLaw.SpringDamper(p1, p2, constant, rest, damping));
                p1.gravity = true;
                p2.gravity = true;
                p1.anchor = false;
                p2.anchor = false;
            }

            if (i < (colms * rows) - colms && i % colms < colms - 1)
            {
                int bottom = i + (int)rows;
                int right = i + 1;

                p1 = particles[right];
                p2 = particles[bottom];

                springDampers.Add(new HooksLaw.SpringDamper(p1, p2, constant, rest, damping));
                p1.gravity = true;
                p2.gravity = true;
                p1.anchor = false;
                p2.anchor = false;
            }

            if (i < (colms * rows) - colms && i % colms < colms - 1)
            {
                int bottom = i + (int)colms;
                int bottomright = bottom + 1;

                p1 = particles[i];
                p2 = particles[bottomright];

                springDampers.Add(new HooksLaw.SpringDamper(p1, p2, constant, rest, damping));
                p1.gravity = true;
                p2.gravity = true;
                p1.anchor = false;
                p2.anchor = false;
            }
        }
    }

    void Update()
    {
        foreach (var s in springDampers)
            s.CalculateForce();

        foreach (var p in particles)
            if (p.gravity == true)
            {
                p.Update(Time.deltaTime);
                CalculateWind(new Vector3(10, 10, 10));
            }

    }
}