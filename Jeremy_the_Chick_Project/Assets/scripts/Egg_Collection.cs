using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Egg_Collection : MonoBehaviour
{
    //jeremy info
    GameObject Jeremy;
    //Jeremy jeremyScript;
    Vector3 jeremyPosition;

    //egg collection number
    public int collectedEggs;
    GameObject[] currentEggs;
    public ParticleSystem collectParticles;

    public Text eggText;


    void Start()
    {
        if (PlayerPrefs.HasKey("CollectedEggs"))
        {
            collectedEggs = PlayerPrefs.GetInt("CollectedEggs");
        }

        Jeremy = GameObject.FindGameObjectWithTag("TheJeremy");
        jeremyPosition = Jeremy.transform.position;
    }

    void Update()
    {
        //track jeremy's current position
        jeremyPosition = Jeremy.transform.position;

        //get all new spawned eggs
        currentEggs = GameObject.FindGameObjectsWithTag("Egg");

        //Debug.Log(currentEggs);

        //check if each coliding with jeremy
        foreach (GameObject item in currentEggs)
        {
            Vector3 itemPosition = item.transform.position;
            if (itemPosition.x < jeremyPosition.x + 0.87f && itemPosition.x > jeremyPosition.x - 0.87f &&
                itemPosition.y < jeremyPosition.y + 0.915f && itemPosition.y > jeremyPosition.y - 0.915f)
            {
                collectedEggs++;
                PlayEggSound();
                Instantiate(collectParticles, item.transform.position, item.transform.rotation);
                Destroy(item.gameObject);
            }
        }
        eggText.text = "Eggs: " + collectedEggs;
        PlayerPrefs.SetInt("CollectedEggs", collectedEggs);
    }

    void PlayEggSound()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/Effects/Egg Collect");
    }
}
