using System.Collections;
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

    // PARTICLE EFFECTS
    public ParticleSystem dust;

    public GameObject gameOverUI;
    public GameObject pauseButton;
    public GameObject itemCanvas;
    public GameObject highScoreGO;

    bool playdeath = false;

    // Start is called before the first frame update
    void Awake()
    {
        movementController = GetComponent<Collisions>();
    }

    // Update is called once per frame
    void Update()
    {

        if (right)
        {

            //setVelocity(new Vector2(2, velocity.y));
            Move();
            if (movementController.data.right.hit)
            {
                right = false;
                this.GetComponent<SpriteRenderer>().flipX = true;
            }
        }
        else
        {
            setVelocity(new Vector2(-2, velocity.y));
            if (movementController.data.left.hit)
            {
                right = true;
                this.GetComponent<SpriteRenderer>().flipX = false;
            }
        }

        if (state_grounded)
        {
            checkObstacle();
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
        if (movementController.data.down.hit && movementController.data.down.obj.Contains("spring") )
        {
            //make sure its grounded
            //Debug.Log(movementController.data.down.velocity);
            if (movementController.data.down.velocity == new Vector3(0.0f, 0.0f, 0.0f))
            {
                SpringJump();
            }
        }

        if (movementController.data.down.hit && movementController.data.down.obj.Contains("Hole"))
        {
            //Debug.Log("Die");
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
            if(hit) //if the object it collides with is not fire
            {
                CreateDust();
                setVelocity(new Vector2(velocity.x, jumpVelocity));
                PlayHopSound();
                state_grounded = false;
                break;
            }
        }
    }

    private void SpringJump()
    {
        //Debug.Log("i hit a spring");
        CreateDust();
        PlaySpringSound();
        setVelocity(new Vector2(velocity.x, jumpVelocity * 2));
        state_grounded = false;
    }

    private void Move()
    {
        if (this.transform.position.x >= 200 && this.transform.position.x < 500)
            setVelocity(new Vector2(2.5f, velocity.y));
        
        else if (this.transform.position.x >= 500 && this.transform.position.x < 1000)
            setVelocity(new Vector2(2.75f, velocity.y));

        else if (this.transform.position.x >= 1000 && this.transform.position.x < 1500)
            setVelocity(new Vector2(3f, velocity.y));

        else if (this.transform.position.x >= 1500 && this.transform.position.x < 2000)
            setVelocity(new Vector2(3.5f, velocity.y));

        else if (this.transform.position.x >= 2000)
            setVelocity(new Vector2(4f, velocity.y));

        else
            setVelocity(new Vector2(2, velocity.y));
    }

    void CreateDust()
    {
        dust.Play();
    }

    void PlaySpringSound()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/Effects/Spring Jump");
    }

    void PlayHopSound()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/Player/Jeremy Hop");
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
        if (playdeath == false)
        {
            FMODUnity.RuntimeManager.PlayOneShot("event:/Player/Death Sound");
            playdeath = true;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Fire")
        {
            //Debug.Log("hit fire");
            GameOver();
        }
    }

}


