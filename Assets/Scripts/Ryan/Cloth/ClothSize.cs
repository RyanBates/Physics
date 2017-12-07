using UnityEngine;

public class ClothSize : MonoBehaviour
{
    public GameObject game;
    public float size = 5;
    
    private void Awake()
    {
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                GameObject p = Instantiate(game, new Vector3(i * 2.5f, -j * 2.5f, 7), Quaternion.identity);
                p.AddComponent<ParticleBehaviour>();
                p.GetComponent<ParticleBehaviour>().particle = new HooksLaw.Particle(p.transform.position, Vector3.zero, 1);
                gameObject.GetComponent<SpringDamperBehaviour>().particles.Add(p.GetComponent<ParticleBehaviour>());
            }
        }
    }
}