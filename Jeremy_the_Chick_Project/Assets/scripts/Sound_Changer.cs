using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_Changer : MonoBehaviour
{
    
    FMOD.Studio.Bus Master;
    float masterVol = 1f;

    void Start()
    {
        Master = FMODUnity.RuntimeManager.GetBus("bus:/Master");
        Master.setVolume(PlayerPrefs.GetFloat("gameVolume"));
    }
}
