using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch_Drag : Touch_Sprite
{
    private bool isDragging = true;
    BoxCollider2D myHitbox;
    Rigidbody2D myRigid;

    private void Awake()
    {
        myHitbox = GetComponent<BoxCollider2D>();
        myHitbox.enabled = false;

        myRigid = GetComponent<Rigidbody2D>();
        myRigid.angularVelocity = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (isDragging)
        {
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
        }

        //Debug.Log(myRigid.angularVelocity);
    }

    private void OnMouseDown()
    {
        isDragging = true;
        myHitbox.enabled = false;
        myRigid.gravityScale = 0;
        myRigid.angularVelocity = 0;
    }


}
