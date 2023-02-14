using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlesAutoDestroyer : MonoBehaviour
{
    // Start is called before the first frame update
    private ParticleSystem ps;
    void Start()
    {
        ps = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!ps.IsAlive())
        {
            Destroy(gameObject);
        }
    }
}
