using UnityEngine;


public class ParticleBehaviour : MonoBehaviour
{
    public HooksLaw.Particle particle;

    
    void Start()
    {
        particle = new HooksLaw.Particle(transform.position, Vector3.zero, 1);
    }

    private void FixedUpdate()
    {
        transform.position = particle.Update(Time.fixedDeltaTime);
    }
}