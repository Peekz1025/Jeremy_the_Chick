using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background_Checker : MonoBehaviour
{

    public GameObject summerbirds;
    public GameObject autumnLeaves;
    public GameObject winterSnow;
    public GameObject springButterflies;

    void Start()
    {
        //if (PlayerPrefs.GetString("Background") == "summer")
        //    summerbirds.SetActive(true);

        if (PlayerPrefs.GetString("Background") == "autumn")
            autumnLeaves.SetActive(true);
    }
}
