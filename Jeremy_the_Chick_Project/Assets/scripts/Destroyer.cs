using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    GameObject Jeremy;
    Vector3 jeremyPosition;
    bool isAlive = true;

    void Start()
    {
        Jeremy = GameObject.FindGameObjectWithTag("TheJeremy");
        jeremyPosition = Jeremy.transform.position;
    }

    void Update()
    {
        //track jeremy's current position
        jeremyPosition = Jeremy.transform.position;

        //if the object goes too far offscreen, destroy it
        if ((transform.position.x <= jeremyPosition.x - 30 && isAlive == true) || (transform.position.y <= jeremyPosition.y - 30 && isAlive == true) || (transform.position.y >= jeremyPosition.y + 30 && isAlive == true))
        {
            isAlive = false;
            Destroy(this.gameObject);
        }
    }

}

