using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customize_Navigation : MonoBehaviour
{

    public GameObject homeMenuUI;
    public GameObject customizeButton;
    public GameObject customMenuUI;
    public GameObject jeremyDefault;


    public void EnterCustomizeMenu()
    {
        homeMenuUI.SetActive(false);
        customizeButton.SetActive(false);
        jeremyDefault.SetActive(false);
        customMenuUI.SetActive(true);
    }

    public void ExitCustomizeMenu()
    {
        homeMenuUI.SetActive(true);
        customizeButton.SetActive(true);
        jeremyDefault.SetActive(true);
        customMenuUI.SetActive(false);
    }
}
