using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Outfit_Checker : MonoBehaviour
{

    public string currentOutfit;
    public Animator JeremyAnimator;


    // Start is called before the first frame update
    void Start()
    {
        //this code will overwrite currentOutfit if input via console window
        //must comment out start for that to work
        if (PlayerPrefs.HasKey("JeremyOutfit"))
        {
            currentOutfit = PlayerPrefs.GetString("JeremyOutfit");
        }
        else
        {
            currentOutfit = "norm";
            PlayerPrefs.SetString("JeremyOutfit", currentOutfit);
        }

        //applies outfit based on PlayerPrefs
        if (currentOutfit == "norm")
        {
            JeremyAnimator.Play("walking_state_norm");
        }
        if (currentOutfit == "party")
        {
            JeremyAnimator.Play("walking_state_party");
        }
        if (currentOutfit == "bow")
        {
            JeremyAnimator.Play("walking_state_bow");
        }
        if (currentOutfit == "shades")
        {
            JeremyAnimator.Play("walking_state_shades");
        }
        if (currentOutfit == "cap")
        {
            JeremyAnimator.Play("walking_state_cap");
        }

    }
}
