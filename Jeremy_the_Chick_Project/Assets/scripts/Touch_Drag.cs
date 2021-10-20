using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch_Drag : Touch_Sprite
{
    GameObject pauseButton;
    public bool isDragging = true;
    BoxCollider2D myHitbox;
    Rigidbody2D myRigid;

    FMOD.Studio.EventInstance playerState;
    //bool isplaying = false;


    private void Awake()
    {
        pauseButton = GameObject.FindGameObjectWithTag("PauseButton");

        myHitbox = GetComponent<BoxCollider2D>();
        myHitbox.enabled = false;

        myRigid = GetComponent<Rigidbody2D>();
        myRigid.angularVelocity = 0;

        //playerState = FMODUnity.RuntimeManager.CreateInstance("event:/Item Dragging");
    }

    // Update is called once per frame
    void Update()
    {
        if (isDragging)
        {
            /*
            if (isplaying == false)
            {
                playerState.start();
                isplaying = true;
            }*/

            Vector3 pos = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, transform.position.z) - transform.position;
            transform.Translate(pos);

            if(!Input.GetMouseButton(0))
            {
                isDragging = false;
                myHitbox.enabled = true;
                myRigid.gravityScale = 1.5f;
            }
            myRigid.angularVelocity = 0;
        }
        else
        {
            myHitbox.enabled = true;
            myRigid.gravityScale = 1.5f;

            //playerState.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
            //isplaying = false;
        }
    }

    private void OnMouseDown()
    {
        if (pauseButton.activeSelf == true)
        {
            isDragging = true;
            myHitbox.enabled = false;
            myRigid.gravityScale = 0;
            myRigid.angularVelocity = 0;
            this.transform.rotation = new Quaternion(0,0,0,0);
            myRigid.velocity = new Vector3(0,0,0);

            /*
            if (isplaying == false)
            {
                playerState.start();
                isplaying = true;
            }*/
        }
    }

}
