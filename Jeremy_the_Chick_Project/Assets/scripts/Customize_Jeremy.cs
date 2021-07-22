using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Customize_Jeremy : MonoBehaviour
{
    //egg collection number
    public int collectedEggs;
    GameObject[] currentEggs;
    public Text eggText;
    public int cost = 50;

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

    public GameObject jeremyHomeSprite;
    SpriteRenderer jeremyHomeSpriteRenderer;
    public Sprite normSpriteHome;
    public Sprite partySpriteHome;
    public Sprite bowSpriteHome;
    public Sprite shadesSpriteHome;
    public Sprite capSpriteHome;


    // Start is called before the first frame update
    public void Start()
    {
        Time.timeScale = 1f;

        if (PlayerPrefs.HasKey("CollectedEggs"))
        {
            collectedEggs = PlayerPrefs.GetInt("CollectedEggs");
        }
        eggText.text = "Eggs: " + collectedEggs;

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

        jeremyHomeSpriteRenderer = jeremyHomeSprite.GetComponent<SpriteRenderer>();

        normAnimator = normSprite.GetComponent<Animator>();
        partyAnimator = partySprite.GetComponent<Animator>();
        bowAnimator = bowSprite.GetComponent<Animator>();
        shadesAnimator = shadesSprite.GetComponent<Animator>();
        capAnimator = capSprite.GetComponent<Animator>();

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
        }
        else
        {
            currentOutfit = "norm";
            normAnimator.Play("walking_state_norm");
        }

        /*
        //manually add or subtract eggs * 2
        collectedEggs = collectedEggs + 10;
        eggText.text = "Eggs: " + collectedEggs;
        PlayerPrefs.SetInt("CollectedEggs", collectedEggs);
        */
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
        if (collectedEggs - cost > 0)
        {
            collectedEggs = collectedEggs - cost;
            eggText.text = "Eggs: " + collectedEggs;
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
        if (collectedEggs - cost > 0)
        {
            collectedEggs = collectedEggs - cost;
            eggText.text = "Eggs: " + collectedEggs;
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
        if (collectedEggs - cost > 0)
        {
            collectedEggs = collectedEggs - cost;
            eggText.text = "Eggs: " + collectedEggs;
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
        if (collectedEggs - cost > 0)
        {
            collectedEggs = collectedEggs - cost;
            eggText.text = "Eggs: " + collectedEggs;
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


}
