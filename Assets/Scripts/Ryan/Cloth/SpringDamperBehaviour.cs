using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringDamperBehaviour : MonoBehaviour
{
    public GameObject game;
    public float rows;
    public float colms;

    ParticleBehaviour pb;
    HooksLaw.SpringDamper Sd;

    HooksLaw.Particle p1;
    HooksLaw.Particle p2;

    public List<HooksLaw.Particle> particles;
    public List<HooksLaw.SpringDamper> springDampers;
    List<GameObject> Objects;
    
    void Start()
    {
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < colms; j++)
            {
                GameObject p = Instantiate(game, new Vector3(i * 2.5f, -j * 2.5f, 7), Quaternion.identity);
                p.AddComponent<ParticleBehaviour>();
                p.GetComponent<ParticleBehaviour>().particle = new HooksLaw.Particle(p.transform.position, Vector3.zero, 1);
                gameObject.GetComponent<SpringDamperBehaviour>().particles.Add(p.GetComponent<ParticleBehaviour>().particle);
                //Objects.Add(gameObject);
            }

        for (int i = 0; i < colms * rows; i++)
        {
            if (i % colms < colms - 1)
            {
                p1 = particles[i];
                p2 = particles[i + 1];

                springDampers.Add(new HooksLaw.SpringDamper(p1, p2, 10, .7f, 4));
                p1.IsAnchor = true;
            }

            if (i < (colms * rows) - colms)
            {
                p1 = particles[i];
                p2 = particles[i + (int)rows];

                springDampers.Add(new HooksLaw.SpringDamper(p1, p2, 10, .7f, 4));               
            }

            if (i < (colms * rows) - colms && i % colms < colms - 1)
            {
                int bottom = i + (int)rows;
                int right = i + 1;

                p1 = particles[right];
                p2 = particles[bottom];

                springDampers.Add(new HooksLaw.SpringDamper(p1, p2, 10, .7f, 4));
            }

            if (i < (colms * rows) - colms && i % colms < colms - 1)
            {
                int bottom = i + (int)colms;
                int bottomright = bottom + 1;

                p1 = particles[i];
                p2 = particles[bottomright];

                springDampers.Add(new HooksLaw.SpringDamper(p1, p2, 10, .7f, 4));
            }
        }
    }

    void Update()
    {
        foreach (var p in particles)
        {
            p.AddForce(new Vector3(0, -9.81f, 0));
            p.Update(Time.deltaTime);
            p.IsGravity = false;

            foreach (var s in springDampers)
            {
                s.CalculateForce();
            }

            p.position = game.transform.position;
        }

    }
}