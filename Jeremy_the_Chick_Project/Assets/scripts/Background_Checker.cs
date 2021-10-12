using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Background_Checker : MonoBehaviour
{

    public GameObject summerBirds;
    public GameObject autumnLeaves;
    public GameObject winterSnow;
    public GameObject springButterflies;

    public GameObject rock;
    public Image rockIcon;
    public Sprite rockSummer;
    public Sprite rockFall;


    void Start()
    {
        SpriteRenderer rockSprite = rock.GetComponent<SpriteRenderer>();

        if (PlayerPrefs.GetString("Background") == "summer")
        {
            //summerbirds.SetActive(true);
            rockSprite.sprite = rockSummer;
            rockIcon.sprite = rockSummer;
        }

        if (PlayerPrefs.GetString("Background") == "autumn")
        {
            autumnLeaves.SetActive(true);
            rockSprite.sprite = rockFall;
            rockIcon.sprite = rockFall;
        }
    }
}
