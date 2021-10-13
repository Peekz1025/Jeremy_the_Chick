using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{

    GameObject Jeremy;
    Vector3 jeremyPosition;
    Vector3 position;

    public bool stuckInGround = false;
    Animator fireAnimator;

    FMOD.Studio.EventInstance fireSound;

    public GameObject gameOverUI;
    public GameObject pausePanel;
    public bool isPaused = false;
    public bool isplaying = true;


    void Start()
    {
        fireAnimator = this.gameObject.GetComponent<Animator>();

        Jeremy = GameObject.FindGameObjectWithTag("TheJeremy");
        jeremyPosition = Jeremy.transform.position;

        gameOverUI = GameObject.FindGameObjectWithTag("GameOverPanel");
        pausePanel = GameObject.FindGameObjectWithTag("PausePanel");

        fireSound = FMODUnity.RuntimeManager.CreateInstance("event:/Effects/Fire");
        fireSound.start();
        fireSound.setVolume(1);
    }

    private void Update()
    {
        if (this.transform.rotation != Quaternion.identity)
            this.transform.rotation = Quaternion.identity;

        jeremyPosition = Jeremy.transform.position;
        position = this.transform.position;

        
        if (jeremyPosition.x > position.x - 18 && jeremyPosition.x < position.x + 18)
            fireSound.setVolume(1);

        else
            fireSound.setVolume(0);


        gameOverUI = GameObject.FindGameObjectWithTag("GameOverPanel");
        pausePanel = GameObject.FindGameObjectWithTag("PausePanel");

        if (pausePanel != null)
        //if (pausePanel.activeSelf == true)
            PauseFireSound();

        if (gameOverUI != null)
        //if (gameOverUI.activeSelf == true)
            StopFireSound();

        if (isPaused && pausePanel == null)
        //if (isPaused && pausePanel.activeSelf == false)
            UnpauseFireSound();

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Water")
        {
            //Debug.Log("collided with water");
            Extinguish();
        }

        if (collision.gameObject.tag == "Rock")
        {
            //Debug.Log("collided with rock");
            //need to check a specific side of the rock
            Extinguish();
        }

        if (collision.gameObject.tag == "Log")
        {
            //Debug.Log("collided with log");
            Destroy(collision.gameObject);
            FMODUnity.RuntimeManager.PlayOneShot("event:/Effects/Fwoosh");
        }

        if (collision.gameObject.tag == "Spring")
        {
            //Debug.Log("collided with spring");
            //come up with some interaction
            //maybe superheats spring and makes that spring jump double distance
        }

        if (collision.gameObject.tag == "Ground")
        {
            Debug.Log("stuck in the ground");
            stuckInGround = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            stuckInGround = false;
        }
    }

    void Extinguish()
    {
        fireSound.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        fireSound.release();
        fireAnimator.Play("fire_extinguish");
        FMODUnity.RuntimeManager.PlayOneShot("event:/Effects/Sizzle");
        Destroy(this.gameObject, 0.5f);
    }

    public void PauseFireSound()
    {
        fireSound.setPaused(true);
        isPaused = true;
        isplaying = false;
    }

    public void StopFireSound()
    {
        fireSound.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        isplaying = false;
    }

    public void UnpauseFireSound()
    {
        fireSound.setPaused(false);
        isPaused = false;
        isplaying = true;
        Debug.Log("unpause fire");
    }

    void OnDestroy()
    {
        fireSound.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
        fireSound.release();
    }
}
