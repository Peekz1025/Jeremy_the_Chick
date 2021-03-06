using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle_Destory : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ParticleSystem ps = GetComponent<ParticleSystem>();
        Destroy(this.gameObject, ps.main.duration);
    }
}
