using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customize_Navigation : MonoBehaviour
{
    //canvases
    public GameObject homeMenuUI;
    public GameObject customizeJeremy1UI;
    public GameObject customizeJeremy2UI;
    public GameObject customizeBackgroundUI;

    //buttons
    public GameObject customizeButton;
    public GameObject jeremyButton;
    public GameObject backgroundButton;
    public GameObject customizeBackButton;

    public GameObject jeremyBackButton;
    public GameObject backgroundBackButton;

    public GameObject grayout;

    //jeremy
    public GameObject jeremyDefault;

    //playing correct animations in customize pages
    GameObject customizer;
    Outfit_Animator op;

    private void Start()
    {
        customizer = GameObject.FindGameObjectWithTag("Customizer");
        op = customizer.GetComponent<Outfit_Animator>();
    }

    public void EnterCustomizeMenu()
    {
        homeMenuUI.SetActive(false);
        customizeButton.SetActive(false);
        jeremyDefault.SetActive(false);
        jeremyButton.SetActive(true);
        backgroundButton.SetActive(true);
        customizeBackButton.SetActive(true);
        //grayout.SetActive(true);
    }

    public void ExitCustomizeMenu()
    {
        homeMenuUI.SetActive(true);
        customizeButton.SetActive(true);
        jeremyDefault.SetActive(true);
        jeremyButton.SetActive(false);
        backgroundButton.SetActive(false);
        customizeBackButton.SetActive(false);
        //grayout.SetActive(false);
    }

    public void EnterCustomizeJeremy1()
    {
        jeremyButton.SetActive(false);
        backgroundButton.SetActive(false);
        customizeJeremy1UI.SetActive(true);
        customizeBackButton.SetActive(false);
        op.OutfitCheckP1();
    }

    public void ExitCustomizeJeremy1()
    {
        jeremyButton.SetActive(true);
        backgroundButton.SetActive(true);
        customizeJeremy1UI.SetActive(false);
        customizeBackButton.SetActive(true);
    }


    public void EnterCustomizeJeremy2()
    {
        customizeJeremy1UI.SetActive(false);
        customizeJeremy2UI.SetActive(true);
        op.OutfitCheckP2();
    }

    public void ExitCustomizeJeremy2()
    {
        customizeJeremy1UI.SetActive(true);
        customizeJeremy2UI.SetActive(false);
        op.OutfitCheckP1();
    }


    public void EnterCustomizeBackground()
    {
        jeremyButton.SetActive(false);
        backgroundButton.SetActive(false);
        customizeBackgroundUI.SetActive(true);
        customizeBackButton.SetActive(false);
    }

    public void ExitCustomizeBackground()
    {
        jeremyButton.SetActive(true);
        backgroundButton.SetActive(true);
        customizeBackgroundUI.SetActive(false);
        customizeBackButton.SetActive(true);
    }


}
