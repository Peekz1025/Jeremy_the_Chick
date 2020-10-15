using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spring : MonoBehaviour
{
    GameObject Jeremy;
    Jeremy jeremyScript;
    Vector3 jeremyPosition;

    // Start is called before the first frame update
    void Start()
    {
        Jeremy = GameObject.FindGameObjectWithTag("TheJeremy");
        jeremyScript = Jeremy.GetComponent<Jeremy>();
        jeremyPosition = Jeremy.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //tracks jeremy's current position
        jeremyPosition = Jeremy.transform.position;

        //if (jeremyPosition.x >= transform.position.x && jumped == false) //&& IsWithin(jeremyPosition.y, transform.position.y-1, transform.position.y+1) 
        /*if (Jeremy. && jumped == false) //&& IsWithin(jeremyPosition.y, transform.position.y-1, transform.position.y+1) 

        {
                jeremyScript.setVelocity(new Vector2(jeremyScript.velocity.x, jeremyScript.jumpVelocity * 2));
            jeremyScript.state_grounded = false;
            jumped = true;
        }*/
    }

}
