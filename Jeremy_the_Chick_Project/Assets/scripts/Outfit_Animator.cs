using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Outfit_Animator : MonoBehaviour
{
    public GameObject normSprite;
    Animator normAnimator;
    public GameObject partySprite;
    Animator partyAnimator;
    public GameObject bowSprite;
    Animator bowAnimator;
    public GameObject shadesSprite;
    Animator shadesAnimator;
    public GameObject capSprite;
    Animator capAnimator;
    public GameObject haloSprite;
    Animator haloAnimator;
    public GameObject wizardSprite;
    Animator wizardAnimator;
    public GameObject pirateSprite;
    Animator pirateAnimator;
    public GameObject beanieSprite;
    Animator beanieAnimator;
    public GameObject crownSprite;
    Animator crownAnimator;

    void Start()
    {
        normAnimator = normSprite.GetComponent<Animator>();
        partyAnimator = partySprite.GetComponent<Animator>();
        bowAnimator = bowSprite.GetComponent<Animator>();
        shadesAnimator = shadesSprite.GetComponent<Animator>();
        capAnimator = capSprite.GetComponent<Animator>();
        haloAnimator = haloSprite.GetComponent<Animator>();
        wizardAnimator = wizardSprite.GetComponent<Animator>();
        pirateAnimator = pirateSprite.GetComponent<Animator>();
        beanieAnimator = beanieSprite.GetComponent<Animator>();
        crownAnimator = crownSprite.GetComponent<Animator>();
    }

    public void OutfitCheckP1()
    {
        if (PlayerPrefs.GetString("JeremyOutfit") == "norm")
            normAnimator.Play("walking_state_norm");

        if (PlayerPrefs.GetString("JeremyOutfit") == "party")
            partyAnimator.Play("walking_state_party");

        if (PlayerPrefs.GetString("JeremyOutfit") == "bow")
            bowAnimator.Play("walking_state_bow");

        if (PlayerPrefs.GetString("JeremyOutfit") == "shades")
            shadesAnimator.Play("walking_state_shades");

        if (PlayerPrefs.GetString("JeremyOutfit") == "cap")
            capAnimator.Play("walking_state_cap");
    }

    public void OutfitCheckP2()
    {
        if (PlayerPrefs.GetString("JeremyOutfit") == "halo")
            haloAnimator.Play("walking_state_halo");

        if (PlayerPrefs.GetString("JeremyOutfit") == "wizard")
            wizardAnimator.Play("walking_state_wizard");

        if (PlayerPrefs.GetString("JeremyOutfit") == "pirate")
            pirateAnimator.Play("walking_state_pirate");

        if (PlayerPrefs.GetString("JeremyOutfit") == "beanie")
            beanieAnimator.Play("walking_state_beanie");

        if (PlayerPrefs.GetString("JeremyOutfit") == "crown")
            crownAnimator.Play("walking_state_crown");
    }
}
