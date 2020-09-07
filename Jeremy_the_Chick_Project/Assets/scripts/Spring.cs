using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spring : MonoBehaviour
{
    /*NOTES
     * he can currently only use a spring once bc it detects when hes greater than it.  could put a wait on turning jumped back to false
     * 
     * the y doesnt matter so he can jump off a spring if hes already in the air.  maybe check the y pos isWithin the pos of the spring and/or check if grounded == true
     *  - checking if grounded is true only delays the jump
     */


    GameObject Jeremy;
    Jeremy jeremyScript;
    Vector3 jeremyPosition;
    bool jumped = false;

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

        if (jeremyPosition.x >= transform.position.x && jumped == false) //&& IsWithin(jeremyPosition.y, transform.position.y-1, transform.position.y+1) 
        {            
            jeremyScript.setVelocity(new Vector2(jeremyScript.velocity.x, jeremyScript.jumpVelocity * 2));
            jeremyScript.state_grounded = false;
            jumped = true;
        }
    }

    public bool IsWithin(float value, float minimum, float maximum)
    {
        return value >= minimum && value <= maximum;
    }
}
