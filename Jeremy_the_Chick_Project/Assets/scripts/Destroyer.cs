using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{

    GameObject Jeremy;
    bool isAlive = true;
    Vector3 jeremyPosition;

    // Start is called before the first frame update
    void Start()
    {
        Jeremy = GameObject.FindGameObjectWithTag("TheJeremy");
        jeremyPosition = Jeremy.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //track jeremy's current position
        jeremyPosition = Jeremy.transform.position;

        //if the object goes too far offscreen, destroy it
        if (transform.position.x <= jeremyPosition.x - 15 && isAlive == true)
        {
            isAlive = false;
            Destroy(this.gameObject);
        }
    }
}
