using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Customize_Jeremy : MonoBehaviour
{
    //egg collection number
    public int collectedEggs;
    public Text eggText1;
    public Text eggText2;
    public Text eggText3;
    public int cost1 = 50;
    public int cost2 = 100;

    public string currentOutfit;

    public GameObject normApplyButton;
    public GameObject partyBuyButton;
    public GameObject partyApplyButton;
    public GameObject bowBuyButton;
    public GameObject bowApplyButton;
    public GameObject shadesBuyButton;
    public GameObject shadesApplyButton;
    public GameObject capBuyButton;
    public GameObject capApplyButton;
    public GameObject haloBuyButton;
    public GameObject haloApplyButton;
    public GameObject wizardBuyButton;
    public GameObject wizardApplyButton;
    public GameObject pirateBuyButton;
    public GameObject pirateApplyButton;
    public GameObject beanieBuyButton;
    public GameObject beanieApplyButton;
    public GameObject crownBuyButton;
    public GameObject crownApplyButton;

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

    public GameObject jeremyHomeSprite;
    SpriteRenderer jeremyHomeSpriteRenderer;

    public Sprite normSpriteHome;
    public Sprite partySpriteHome;
    public Sprite bowSpriteHome;
    public Sprite shadesSpriteHome;
    public Sprite capSpriteHome;
    public Sprite haloSpriteHome;
    public Sprite wizardSpriteHome;
    public Sprite pirateSpriteHome;
    public Sprite beanieSpriteHome;
    public Sprite crownSpriteHome;


    // Start is called before the first frame update
    public void Start()
    {
        Time.timeScale = 1f;

        if (PlayerPrefs.HasKey("CollectedEggs"))
        {
            collectedEggs = PlayerPrefs.GetInt("CollectedEggs");
        }
        eggText1.text = "Eggs: " + collectedEggs;
        eggText2.text = "Eggs: " + collectedEggs;
        eggText3.text = "Eggs: " + collectedEggs;

        //set buttons active based on if you have the outfit already
        if (!PlayerPrefs.HasKey("HasParty")) //if the variable does not exist at all
        {
            PlayerPrefs.SetString("HasParty", "no");
            partyBuyButton.SetActive(true);
            partyApplyButton.SetActive(false);
        }
        else
        {
            if (PlayerPrefs.GetString("HasParty") == "no")
            {
                partyBuyButton.SetActive(true);
                partyApplyButton.SetActive(false);
            }
            if (PlayerPrefs.GetString("HasParty") == "yes")
            {
                partyBuyButton.SetActive(false);
                partyApplyButton.SetActive(true);
            }
        }

        if (!PlayerPrefs.HasKey("HasBow"))
        {
            PlayerPrefs.SetString("HasBow", "no");
            bowBuyButton.SetActive(true);
            bowApplyButton.SetActive(false);
        }
        else
        {
            if (PlayerPrefs.GetString("HasBow") == "no")
            {
                bowBuyButton.SetActive(true);
                bowApplyButton.SetActive(false);
            }
            if (PlayerPrefs.GetString("HasBow") == "yes")
            {
                bowBuyButton.SetActive(false);
                bowApplyButton.SetActive(true);
            }
        }

        if (!PlayerPrefs.HasKey("HasShades"))
        {
            PlayerPrefs.SetString("HasShades", "no");
            shadesBuyButton.SetActive(true);
            shadesApplyButton.SetActive(false);
        }
        else
        {
            if (PlayerPrefs.GetString("HasShades") == "no")
            {
                shadesBuyButton.SetActive(true);
                shadesApplyButton.SetActive(false);
            }
            if (PlayerPrefs.GetString("HasShades") == "yes")
            {
                shadesBuyButton.SetActive(false);
                shadesApplyButton.SetActive(true);
            }
        }

        if (!PlayerPrefs.HasKey("HasCap"))
        {
            PlayerPrefs.SetString("HasCap", "no");
            capBuyButton.SetActive(true);
            capApplyButton.SetActive(false);
        }
        else
        {
            if (PlayerPrefs.GetString("HasCap") == "no")
            {
                capBuyButton.SetActive(true);
                capApplyButton.SetActive(false);
            }
            if (PlayerPrefs.GetString("HasCap") == "yes")
            {
                capBuyButton.SetActive(false);
                capApplyButton.SetActive(true);
            }
        }


        if (!PlayerPrefs.HasKey("HasHalo"))
        {
            PlayerPrefs.SetString("HasHalo", "no");
            haloBuyButton.SetActive(true);
            haloApplyButton.SetActive(false);
        }
        else
        {
            if (PlayerPrefs.GetString("HasHalo") == "no")
            {
                haloBuyButton.SetActive(true);
                haloApplyButton.SetActive(false);
            }
            if (PlayerPrefs.GetString("HasHalo") == "yes")
            {
                haloBuyButton.SetActive(false);
                haloApplyButton.SetActive(true);
            }
        }

        if (!PlayerPrefs.HasKey("HasWizard"))
        {
            PlayerPrefs.SetString("HasWizard", "no");
            wizardBuyButton.SetActive(true);
            wizardApplyButton.SetActive(false);
        }
        else
        {
            if (PlayerPrefs.GetString("HasWizard") == "no")
            {
                wizardBuyButton.SetActive(true);
                wizardApplyButton.SetActive(false);
            }
            if (PlayerPrefs.GetString("HasWizard") == "yes")
            {
                wizardBuyButton.SetActive(false);
                wizardApplyButton.SetActive(true);
            }
        }

        if (!PlayerPrefs.HasKey("HasPirate"))
        {
            PlayerPrefs.SetString("HasPirate", "no");
            pirateBuyButton.SetActive(true);
            pirateApplyButton.SetActive(false);
        }
        else
        {
            if (PlayerPrefs.GetString("HasPirate") == "no")
            {
                pirateBuyButton.SetActive(true);
                pirateApplyButton.SetActive(false);
            }
            if (PlayerPrefs.GetString("HasPirate") == "yes")
            {
                pirateBuyButton.SetActive(false);
                pirateApplyButton.SetActive(true);
            }
        }

        if (!PlayerPrefs.HasKey("HasBeanie"))
        {
            PlayerPrefs.SetString("HasBeanie", "no");
            beanieBuyButton.SetActive(true);
            beanieApplyButton.SetActive(false);
        }
        else
        {
            if (PlayerPrefs.GetString("HasBeanie") == "no")
            {
                beanieBuyButton.SetActive(true);
                beanieApplyButton.SetActive(false);
            }
            if (PlayerPrefs.GetString("HasBeanie") == "yes")
            {
                beanieBuyButton.SetActive(false);
                beanieApplyButton.SetActive(true);
            }
        }

        if (!PlayerPrefs.HasKey("HasCrown"))
        {
            PlayerPrefs.SetString("HasCrown", "no");
            crownBuyButton.SetActive(true);
            crownApplyButton.SetActive(false);
        }
        else
        {
            if (PlayerPrefs.GetString("HasCrown") == "no")
            {
                crownBuyButton.SetActive(true);
                crownApplyButton.SetActive(false);
            }
            if (PlayerPrefs.GetString("HasCrown") == "yes")
            {
                crownBuyButton.SetActive(false);
                crownApplyButton.SetActive(true);
            }
        }

        jeremyHomeSpriteRenderer = jeremyHomeSprite.GetComponent<SpriteRenderer>();

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



        //set default animation
        if (PlayerPrefs.HasKey("JeremyOutfit"))
        {
            if (PlayerPrefs.GetString("JeremyOutfit") == "norm")
            {
                currentOutfit = "norm";
                normAnimator.Play("walking_state_norm");
                jeremyHomeSpriteRenderer.sprite = normSpriteHome;
            }
            if (PlayerPrefs.GetString("JeremyOutfit") == "party")
            {
                currentOutfit = "party";
                partyAnimator.Play("walking_state_party");
                jeremyHomeSpriteRenderer.sprite = partySpriteHome;
            }
            if (PlayerPrefs.GetString("JeremyOutfit") == "bow")
            {
                currentOutfit = "bow";
                bowAnimator.Play("walking_state_bow");
                jeremyHomeSpriteRenderer.sprite = bowSpriteHome;
            }
            if (PlayerPrefs.GetString("JeremyOutfit") == "shades")
            {
                currentOutfit = "shades";
                shadesAnimator.Play("walking_state_shades");
                jeremyHomeSpriteRenderer.sprite = shadesSpriteHome;
            }
            if (PlayerPrefs.GetString("JeremyOutfit") == "cap")
            {
                currentOutfit = "cap";
                capAnimator.Play("walking_state_cap");
                jeremyHomeSpriteRenderer.sprite = capSpriteHome;
            }

            if (PlayerPrefs.GetString("JeremyOutfit") == "halo")
            {
                currentOutfit = "halo";
                haloAnimator.Play("walking_state_halo");
                jeremyHomeSpriteRenderer.sprite = haloSpriteHome;
            }
            if (PlayerPrefs.GetString("JeremyOutfit") == "wizard")
            {
                currentOutfit = "wizard";
                wizardAnimator.Play("walking_state_wizard");
                jeremyHomeSpriteRenderer.sprite = wizardSpriteHome;
            }
            if (PlayerPrefs.GetString("JeremyOutfit") == "pirate")
            {
                currentOutfit = "pirate";
                pirateAnimator.Play("walking_state_pirate");
                jeremyHomeSpriteRenderer.sprite = pirateSpriteHome;
            }
            if (PlayerPrefs.GetString("JeremyOutfit") == "beanie")
            {
                currentOutfit = "beanie";
                beanieAnimator.Play("walking_state_beanie");
                jeremyHomeSpriteRenderer.sprite = beanieSpriteHome;
            }
            if (PlayerPrefs.GetString("JeremyOutfit") == "crown")
            {
                currentOutfit = "crown";
                crownAnimator.Play("walking_state_crown");
                jeremyHomeSpriteRenderer.sprite = crownSpriteHome;
            }
        }
        else
        {
            currentOutfit = "norm";
            normAnimator.Play("walking_state_norm");
        }

        /*
        //manually add or subtract eggs * 2
        collectedEggs -= 700;
        eggText1.text = "Eggs: " + collectedEggs;
        eggText2.text = "Eggs: " + collectedEggs;
        eggText3.text = "Eggs: " + collectedEggs;
        PlayerPrefs.SetInt("CollectedEggs", collectedEggs);
        */
    }

    public void FreeEggs()
    {
        //manually add or subtract eggs * 2
        collectedEggs += 723;
        eggText1.text = "Eggs: " + collectedEggs;
        eggText2.text = "Eggs: " + collectedEggs;
        eggText3.text = "Eggs: " + collectedEggs;
        PlayerPrefs.SetInt("CollectedEggs", collectedEggs);
    }

    public void ApplyNorm()
    {
        //set current outfit to new outfit
        currentOutfit = "norm";
        PlayerPrefs.SetString("JeremyOutfit", currentOutfit);

        jeremyHomeSpriteRenderer.sprite = normSpriteHome;

        //animate new sprite
        normAnimator.Play("walking_state_norm");

        //cancel old animation
        partyAnimator.Play("standing_state_party");
        bowAnimator.Play("standing_state_bow");
        shadesAnimator.Play("standing_state_shades");
        capAnimator.Play("standing_state_cap");
    }

    public void BuyParty()
    {
        //if you have enough eggs to buy
        if (collectedEggs - cost1 >= 0)
        {
            collectedEggs = collectedEggs - cost1;
            eggText1.text = "Eggs: " + collectedEggs;
            eggText2.text = "Eggs: " + collectedEggs;
            eggText3.text = "Eggs: " + collectedEggs;
            PlayerPrefs.SetInt("CollectedEggs", collectedEggs);

            //remove buy button & add apply button
            partyBuyButton.SetActive(false);
            partyApplyButton.SetActive(true);

            PlayerPrefs.SetString("HasParty", "yes");
        }
    }

    public void ApplyParty()
    {
        //set current outfit to new outfit
        currentOutfit = "party";
        PlayerPrefs.SetString("JeremyOutfit", currentOutfit);

        jeremyHomeSpriteRenderer.sprite = partySpriteHome;

        //animate new sprite
        partyAnimator.Play("walking_state_party");

        //cancel old animation
        normAnimator.Play("standing_state_norm");
        bowAnimator.Play("standing_state_bow");
        shadesAnimator.Play("standing_state_shades");
        capAnimator.Play("standing_state_cap");
    }

    public void BuyBow()
    {
        //if you have enough eggs to buy
        if (collectedEggs - cost1 >= 0)
        {
            collectedEggs = collectedEggs - cost1;
            eggText1.text = "Eggs: " + collectedEggs;
            eggText2.text = "Eggs: " + collectedEggs;
            eggText3.text = "Eggs: " + collectedEggs;
            PlayerPrefs.SetInt("CollectedEggs", collectedEggs);

            //remove buy button & add apply button
            bowBuyButton.SetActive(false);
            bowApplyButton.SetActive(true);

            PlayerPrefs.SetString("HasBow", "yes");
        }
    }

    public void ApplyBow()
    {
        //set current outfit to new outfit
        currentOutfit = "bow";
        PlayerPrefs.SetString("JeremyOutfit", currentOutfit);

        jeremyHomeSpriteRenderer.sprite = bowSpriteHome;

        //animate new sprite
        bowAnimator.Play("walking_state_bow");

        //cancel old animation
        normAnimator.Play("standing_state_norm");
        partyAnimator.Play("standing_state_party");
        shadesAnimator.Play("standing_state_shades");
        capAnimator.Play("standing_state_cap");
    }

    public void BuyShades()
    {
        //if you have enough eggs to buy
        if (collectedEggs - cost1 >= 0)
        {
            collectedEggs = collectedEggs - cost1;
            eggText1.text = "Eggs: " + collectedEggs;
            eggText2.text = "Eggs: " + collectedEggs;
            eggText3.text = "Eggs: " + collectedEggs;
            PlayerPrefs.SetInt("CollectedEggs", collectedEggs);

            //remove buy button & add apply button
            shadesBuyButton.SetActive(false);
            shadesApplyButton.SetActive(true);

            PlayerPrefs.SetString("HasShades", "yes");
        }
    }

    public void ApplyShades()
    {
        //set current outfit to new outfit
        currentOutfit = "shades";
        PlayerPrefs.SetString("JeremyOutfit", currentOutfit);

        jeremyHomeSpriteRenderer.sprite = shadesSpriteHome;

        //animate new sprite
        shadesAnimator.Play("walking_state_shades");

        //cancel old animation
        normAnimator.Play("standing_state_norm");
        partyAnimator.Play("standing_state_party");
        bowAnimator.Play("standing_state_bow");
        capAnimator.Play("standing_state_cap");
    }

    public void BuyCap()
    {
        //if you have enough eggs to buy
        if (collectedEggs - cost1 >= 0)
        {
            collectedEggs = collectedEggs - cost1;
            eggText1.text = "Eggs: " + collectedEggs;
            eggText2.text = "Eggs: " + collectedEggs;
            eggText3.text = "Eggs: " + collectedEggs;
            PlayerPrefs.SetInt("CollectedEggs", collectedEggs);

            //remove buy button & add apply button
            capBuyButton.SetActive(false);
            capApplyButton.SetActive(true);

            PlayerPrefs.SetString("HasCap", "yes");
        }
    }

    public void ApplyCap()
    {
        //set current outfit to new outfit
        currentOutfit = "cap";
        PlayerPrefs.SetString("JeremyOutfit", currentOutfit);

        jeremyHomeSpriteRenderer.sprite = capSpriteHome;

        //animate new sprite
        capAnimator.Play("walking_state_cap");

        //cancel old animation
        normAnimator.Play("standing_state_norm");
        partyAnimator.Play("standing_state_party");
        bowAnimator.Play("standing_state_bow");
        shadesAnimator.Play("standing_state_shades");
    }
    
    public void BuyHalo()
    {
        //if you have enough eggs to buy
        if (collectedEggs - cost2 >= 0)
        {
            collectedEggs = collectedEggs - cost2;
            eggText1.text = "Eggs: " + collectedEggs;
            eggText2.text = "Eggs: " + collectedEggs;
            eggText3.text = "Eggs: " + collectedEggs;
            PlayerPrefs.SetInt("CollectedEggs", collectedEggs);

            //remove buy button & add apply button
            haloBuyButton.SetActive(false);
            haloApplyButton.SetActive(true);

            PlayerPrefs.SetString("HasHalo", "yes");
        }
    }

    public void ApplyHalo()
    {
        //set current outfit to new outfit
        currentOutfit = "halo";
        PlayerPrefs.SetString("JeremyOutfit", currentOutfit);

        jeremyHomeSpriteRenderer.sprite = haloSpriteHome;

        //animate new sprite
        haloAnimator.Play("walking_state_halo");

        //cancel old animation
        wizardAnimator.Play("standing_state_wizard");
        pirateAnimator.Play("standing_state_pirate");
        beanieAnimator.Play("standing_state_beanie");
        crownAnimator.Play("standing_state_crown");
    }

    public void BuyWizard()
    {
        //if you have enough eggs to buy
        if (collectedEggs - cost2 >= 0)
        {
            collectedEggs = collectedEggs - cost2;
            eggText1.text = "Eggs: " + collectedEggs;
            eggText2.text = "Eggs: " + collectedEggs;
            eggText3.text = "Eggs: " + collectedEggs;
            PlayerPrefs.SetInt("CollectedEggs", collectedEggs);

            //remove buy button & add apply button
            wizardBuyButton.SetActive(false);
            wizardApplyButton.SetActive(true);

            PlayerPrefs.SetString("HasWizard", "yes");
        }
    }

    public void ApplyWizard()
    {
        //set current outfit to new outfit
        currentOutfit = "wizard";
        PlayerPrefs.SetString("JeremyOutfit", currentOutfit);

        jeremyHomeSpriteRenderer.sprite = wizardSpriteHome;

        //animate new sprite
        wizardAnimator.Play("walking_state_wizard");

        //cancel old animation
        haloAnimator.Play("standing_state_halo");
        pirateAnimator.Play("standing_state_pirate");
        beanieAnimator.Play("standing_state_beanie");
        crownAnimator.Play("standing_state_crown");
    }
    
    public void BuyPirate()
    {
        //if you have enough eggs to buy
        if (collectedEggs - cost2 >= 0)
        {
            collectedEggs = collectedEggs - cost2;
            eggText1.text = "Eggs: " + collectedEggs;
            eggText2.text = "Eggs: " + collectedEggs;
            eggText3.text = "Eggs: " + collectedEggs;
            PlayerPrefs.SetInt("CollectedEggs", collectedEggs);

            //remove buy button & add apply button
            pirateBuyButton.SetActive(false);
            pirateApplyButton.SetActive(true);

            PlayerPrefs.SetString("HasPirate", "yes");
        }
    }

    public void ApplyPirate()
    {
        //set current outfit to new outfit
        currentOutfit = "pirate";
        PlayerPrefs.SetString("JeremyOutfit", currentOutfit);

        jeremyHomeSpriteRenderer.sprite = pirateSpriteHome;

        //animate new sprite
        pirateAnimator.Play("walking_state_pirate");

        //cancel old animation
        haloAnimator.Play("standing_state_halo");
        wizardAnimator.Play("standing_state_wizard");
        beanieAnimator.Play("standing_state_beanie");
        crownAnimator.Play("standing_state_crown");
    }

    public void BuyBeanie()
    {
        //if you have enough eggs to buy
        if (collectedEggs - cost2 >= 0)
        {
            collectedEggs = collectedEggs - cost2;
            eggText1.text = "Eggs: " + collectedEggs;
            eggText2.text = "Eggs: " + collectedEggs;
            eggText3.text = "Eggs: " + collectedEggs;
            PlayerPrefs.SetInt("CollectedEggs", collectedEggs);

            //remove buy button & add apply button
            beanieBuyButton.SetActive(false);
            beanieApplyButton.SetActive(true);

            PlayerPrefs.SetString("HasBeanie", "yes");
        }
    }

    public void ApplyBeanie()
    {
        //set current outfit to new outfit
        currentOutfit = "beanie";
        PlayerPrefs.SetString("JeremyOutfit", currentOutfit);

        jeremyHomeSpriteRenderer.sprite = beanieSpriteHome;

        //animate new sprite
        beanieAnimator.Play("walking_state_beanie");

        //cancel old animation
        haloAnimator.Play("standing_state_halo");
        wizardAnimator.Play("standing_state_wizard");
        pirateAnimator.Play("standing_state_pirate");
        crownAnimator.Play("standing_state_crown");
    }

    public void BuyCrown()
    {
        //if you have enough eggs to buy
        if (collectedEggs - cost2 >= 0)
        {
            collectedEggs = collectedEggs - cost2;
            eggText1.text = "Eggs: " + collectedEggs;
            eggText2.text = "Eggs: " + collectedEggs;
            eggText3.text = "Eggs: " + collectedEggs;
            PlayerPrefs.SetInt("CollectedEggs", collectedEggs);

            //remove buy button & add apply button
            crownBuyButton.SetActive(false);
            crownApplyButton.SetActive(true);

            PlayerPrefs.SetString("HasCrown", "yes");
        }
    }

    public void ApplyCrown()
    {
        //set current outfit to new outfit
        currentOutfit = "crown";
        PlayerPrefs.SetString("JeremyOutfit", currentOutfit);

        jeremyHomeSpriteRenderer.sprite = crownSpriteHome;

        //animate new sprite
        crownAnimator.Play("walking_state_crown");

        //cancel old animation
        haloAnimator.Play("standing_state_halo");
        wizardAnimator.Play("standing_state_wizard");
        pirateAnimator.Play("standing_state_pirate");
        beanieAnimator.Play("standing_state_beanie");
    }

}
