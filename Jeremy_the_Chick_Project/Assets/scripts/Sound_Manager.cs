using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sound_Manager : MonoBehaviour
{

    FMOD.Studio.Bus Master;
    float masterVol = 1f;

    
    [SerializeField] Slider volumeSlider;

    void Start()
    {
        Master = FMODUnity.RuntimeManager.GetBus("bus:/Master");


        if (!PlayerPrefs.HasKey("gameVolume"))
        {
            PlayerPrefs.SetFloat("gameVolume", 1);
            Load();
        }
        else
        {
            Load();
        }
    }

    public void ChangeVolume()
    {
        Master.setVolume(masterVol);
        Save();
    }

    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("gameVolume");

    }

    private void Save()
    {
        PlayerPrefs.SetFloat("gameVolume", volumeSlider.value);
    }

    public void AdjustSound()
    {
        Master.setVolume(PlayerPrefs.GetFloat("gameVolume"));
    }

}
