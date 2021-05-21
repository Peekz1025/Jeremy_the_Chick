using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thud_Sound : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (this.gameObject.tag == "Rock")
        {
            PlayHeavyThudSound();
        }
        else
        {
            PlayLightThudSound();
        }
    }

    void PlayLightThudSound()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/Effects/Light Drop");
    }

    void PlayHeavyThudSound()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/Effects/Heavy Drop");
    }
}
