﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lose_Condition : MonoBehaviour
{

    GameObject Jeremy;
    Jeremy jeremyScript;
    Vector3 jeremyPosition;

    GameObject WorldBuilder;
    World_Builder worldBuilderScript;

    public GameObject gameOverUI;
    public GameObject pauseButton;
    public GameObject itemCanvas;
    public GameObject highScoreGO;

    bool playdeath = false;


    void Start()
    {
        Jeremy = GameObject.FindGameObjectWithTag("TheJeremy");
        jeremyScript = Jeremy.GetComponent<Jeremy>();
        jeremyPosition = Jeremy.transform.position;

        WorldBuilder = GameObject.FindGameObjectWithTag("WorldBuilder");
        worldBuilderScript = WorldBuilder.GetComponent<World_Builder>();
    }

    void Update()
    {
        jeremyPosition = Jeremy.transform.position;

        //if jeremy dies via hole
        int i = 0;
        foreach (GameObject piece in worldBuilderScript.currentWorld)
        {
            //if the piece exists, get its anchors
            if (piece != null)
            {
                Transform left = piece.GetComponent<World_Piece>().leftAnchor;
                Transform right = piece.GetComponent<World_Piece>().rightAnchor;

                //catches if jeremy is going left and he falls off the world
                if (i == 0 && jeremyPosition.x <= left.position.x && jeremyPosition.y < -10)
                {
                    GameOver();
                }

                //if jeremy is on that terrain piece and hes in the air
                if (jeremyPosition.x > left.position.x && jeremyPosition.x < right.position.x && jeremyScript.state_grounded == false)
                {
                    //if he goes 8 units below the surface, game over
                    if (jeremyPosition.y <= piece.transform.position.y - 7)
                    {
                        GameOver();
                    }
                }
                i++;
            }
        }
    }

    void GameOver()
    {
        PlayDeathSound();
        gameOverUI.SetActive(true);
        pauseButton.SetActive(false);
        itemCanvas.SetActive(false);
        highScoreGO.SetActive(true);
        Time.timeScale = 0f;
    }

    void PlayDeathSound()
    {
        if(playdeath == false)
        {
            FMODUnity.RuntimeManager.PlayOneShot("event:/Player/Death Sound");
            playdeath = true;
        }
    }
}
