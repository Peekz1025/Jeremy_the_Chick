using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Customize_Background : MonoBehaviour
{

    //egg collection number
    public int collectedEggs;
    public Text eggText1;
    public Text eggText2;
    public Text eggText3;
    public int cost = 500;

    public string currentBackground;

    public GameObject summerApplyButton;
    public GameObject autumnBuyButton;
    public GameObject autumnApplyButton;
    public GameObject winterBuyButton;
    public GameObject winterApplyButton;
    public GameObject springBuyButton;
    public GameObject springApplyButton;

    public GameObject summerHomeScreen;
    public GameObject autumnHomeScreen;
    public GameObject winterHomeScreen;
    public GameObject springHomeScreen;


    void Start()
    {
        if (PlayerPrefs.HasKey("CollectedEggs"))
        {
            collectedEggs = PlayerPrefs.GetInt("CollectedEggs");
        }
        eggText1.text = "Eggs: " + collectedEggs;
        eggText2.text = "Eggs: " + collectedEggs;
        eggText3.text = "Eggs: " + collectedEggs;


        //set buttons active based on if you have the outfit already
        if (!PlayerPrefs.HasKey("HasAutumn")) //if the variable does not exist at all
        {
            PlayerPrefs.SetString("HasAutumn", "no");
            autumnBuyButton.SetActive(true);
            autumnApplyButton.SetActive(false);
        }
        else
        {
            if (PlayerPrefs.GetString("HasAutumn") == "no")
            {
                autumnBuyButton.SetActive(true);
                autumnApplyButton.SetActive(false);
            }
            if (PlayerPrefs.GetString("HasAutumn") == "yes")
            {
                autumnBuyButton.SetActive(false);
                autumnApplyButton.SetActive(true);
            }
        }
        /*
        if (!PlayerPrefs.HasKey("HasWinter")) //if the variable does not exist at all
        {
            PlayerPrefs.SetString("HasWinter", "no");
            winterBuyButton.SetActive(true);
            winterApplyButton.SetActive(false);
        }
        else
        {
            if (PlayerPrefs.GetString("HasWinter") == "no")
            {
                winterBuyButton.SetActive(true);
                winterApplyButton.SetActive(false);
            }
            if (PlayerPrefs.GetString("HasWinter") == "yes")
            {
                winterBuyButton.SetActive(false);
                winterApplyButton.SetActive(true);
            }
        }
        if (!PlayerPrefs.HasKey("HasSpring")) //if the variable does not exist at all
        {
            PlayerPrefs.SetString("HasSpring", "no");
            springBuyButton.SetActive(true);
            springApplyButton.SetActive(false);
        }
        else
        {
            if (PlayerPrefs.GetString("HasSpring") == "no")
            {
                springBuyButton.SetActive(true);
                springApplyButton.SetActive(false);
            }
            if (PlayerPrefs.GetString("HasSpring") == "yes")
            {
                springBuyButton.SetActive(false);
                springApplyButton.SetActive(true);
            }
        }*/

        //set default animation
        if (PlayerPrefs.HasKey("Background"))
        {
            if (PlayerPrefs.GetString("Background") == "summer")
            {
                currentBackground = "summer";
                summerHomeScreen.SetActive(true);
            }
            if (PlayerPrefs.GetString("Background") == "autumn")
            {
                currentBackground = "autumn";
                autumnHomeScreen.SetActive(true);
            }/*
            if (PlayerPrefs.GetString("Background") == "winter")
            {
                currentBackground = "winter";
                winterHomeScreen.SetActive(true);
            }
            if (PlayerPrefs.GetString("Background") == "spring")
            {
                currentBackground = "spring";
                winterHomeScreen.SetActive(true);
            }*/
        }
        else
        {
            PlayerPrefs.SetString("Background", "summer");
            currentBackground = "summer";
            summerHomeScreen.SetActive(true);
        }

        //override current background for testing
        /*PlayerPrefs.SetString("Background", "summer");
        currentBackground = "summer";
        summerHomeScreen.SetActive(true);*/
    }

    public void ApplySummer()
    {
        //set current background to new background
        PlayerPrefs.SetString("Background", "summer");
        currentBackground = "summer";

        //activate new background
        summerHomeScreen.SetActive(true);

        //cancel old background
        autumnHomeScreen.SetActive(false);
        winterHomeScreen.SetActive(false);
        springHomeScreen.SetActive(false);
    }

    public void BuyAutumn()
    {
        //if you have enough eggs to buy
        if (collectedEggs - cost >= 0)
        {
            collectedEggs = collectedEggs - cost;
            eggText1.text = "Eggs: " + collectedEggs;
            eggText2.text = "Eggs: " + collectedEggs;
            eggText3.text = "Eggs: " + collectedEggs; PlayerPrefs.SetInt("CollectedEggs", collectedEggs);

            //remove buy button & add apply button
            autumnBuyButton.SetActive(false);
            autumnApplyButton.SetActive(true);

            PlayerPrefs.SetString("HasAutumn", "yes");
        }
    }

    public void ApplyAutumn()
    {
        //set current background to new background
        PlayerPrefs.SetString("Background", "autumn");
        currentBackground = "autumn";

        //activate new background
        autumnHomeScreen.SetActive(true);

        //cancel old background
        summerHomeScreen.SetActive(false);
        winterHomeScreen.SetActive(false);
        springHomeScreen.SetActive(false);
    }


}
