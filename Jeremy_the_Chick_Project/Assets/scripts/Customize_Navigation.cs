using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customize_Navigation : MonoBehaviour
{

    //UI elements
    public GameObject homeMenuUI;
    public GameObject customizeButton;
    public GameObject customMenuUI;
    public GameObject jeremyDefault;

    //costumes
    public GameObject jeremy_Norm;
    public GameObject jeremy_Party;
    public GameObject jeremy_Bow;
    public GameObject jeremy_Shades;
    public GameObject jeremy_Cap;



    public void EnterCustomizeMenu()
    {
        homeMenuUI.SetActive(false);
        customizeButton.SetActive(false);
        jeremyDefault.SetActive(false);
        customMenuUI.SetActive(true);

        jeremy_Norm.SetActive(true);
        jeremy_Party.SetActive(true);
        jeremy_Bow.SetActive(true);
        jeremy_Shades.SetActive(true);
        jeremy_Cap.SetActive(true);
    }

    public void ExitCustomizeMenu()
    {
        homeMenuUI.SetActive(true);
        customizeButton.SetActive(true);
        jeremyDefault.SetActive(true);
        customMenuUI.SetActive(false);

        jeremy_Norm.SetActive(false);
        jeremy_Party.SetActive(false);
        jeremy_Bow.SetActive(false);
        jeremy_Shades.SetActive(false);
        jeremy_Cap.SetActive(false);
    }
}
