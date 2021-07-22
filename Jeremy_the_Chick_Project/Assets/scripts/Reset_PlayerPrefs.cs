using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset_PlayerPrefs : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.DeleteAll();
    }
}
