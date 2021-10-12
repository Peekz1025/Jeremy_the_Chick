using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    public ParticleSystem splash;


    void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(splash, transform.position, transform.rotation);
        Destroy(this.gameObject);
        //PlaySplashSound();
    }

    void PlaySplashSound()
    {
        //FMODUnity.RuntimeManager.PlayOneShot("event:/Effects/Item Destroyed");
    }
}
