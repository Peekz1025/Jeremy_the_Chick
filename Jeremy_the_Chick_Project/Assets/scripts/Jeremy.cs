﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jeremy : Entity
{
    // CONFIGURABLES
    public float jumpReactDistance = 0.75f; // Distance from an obstacle at which Jeremy jumps.
    public float jumpVelocity = 8f; // Upward velocity Jeremy gains when he jumps.

    // LOCAL DATA
    private bool right = true;
    public bool state_grounded = true;

    // LOSE CONDITION
    Vector2 startFallingPos;
    bool startFallingPosTracked = false;
    public GameObject gameOverUI;
    public GameObject pauseButton;

    // PARTICLE EFFECTS
    public ParticleSystem dust;


    // Start is called before the first frame update
    void Awake()
    {
        movementController = GetComponent<Collisions>();
    }

    // Update is called once per frame
    void Update()
    {
        if(right)
        {
            setVelocity(new Vector2(2, velocity.y));
            if(movementController.data.right.hit) right = false;
        }
        else
        {
            setVelocity(new Vector2(-2, velocity.y));
            if(movementController.data.left.hit) right = true;
        }

        if (state_grounded)
        {
            checkObstacle();
            startFallingPos = new Vector2(-100,-100);
            startFallingPosTracked = false;
        }

        if (movementController.data.down.hit)
        {
            state_grounded = true;
        }
        else
        {
            state_grounded = false;
        }

        //checks to see if it collided with a spring below it
        if (movementController.data.down.hit && movementController.data.down.obj.Contains("Spring"))
            SpringJump();

        // begins to track falling position for gameover
        if (!state_grounded && !startFallingPosTracked)
        {
            startFallingPos = transform.position;
            startFallingPosTracked = true;
        }

        // checks if he's been falling for 10 units
        if (transform.position.y <= startFallingPos.y - 10)
        {
            GameOver();
        }
    }

    private void LateUpdate()
    {       
        applyVelocity();
    }

    private void checkObstacle()
    {
        Vector2 rayOrigin;
        Vector2 rayDirection;

        if(right)
        {
            rayOrigin = movementController.myOrigins.bottomRight;
            rayDirection = Vector2.right;
        }
        else
        {
            rayOrigin = movementController.myOrigins.bottomLeft;
            rayDirection = Vector2.left;
        }

        Vector2 raySpacing = Vector2.up * movementController.verticalRaySpace;
        float rayLength = jumpReactDistance;
        int rayCount = movementController.verticalRayCount;

        for(int i = 0; i < rayCount; i++)
        {
            RaycastHit2D hit = Physics2D.Raycast(rayOrigin + (raySpacing * i), rayDirection, rayLength, movementController.collisionMask);
            Debug.DrawRay(rayOrigin + (raySpacing * i), rayDirection*rayLength, Color.red);

            // put code here for if the object hits from above
            if(hit)
            {
                CreateDust();
                setVelocity(new Vector2(velocity.x, jumpVelocity));

                state_grounded = false;
                break;
            }
        }
    }

    private void SpringJump()
    {
        //Debug.Log("i hit a spring");
        CreateDust();
        setVelocity(new Vector2(velocity.x, jumpVelocity * 2));
        state_grounded = false;
    }

    void GameOver()
    {
        gameOverUI.SetActive(true);
        pauseButton.SetActive(false);
        Time.timeScale = 0f;
    }

    void CreateDust()
    {
        dust.Play();
    }
}
