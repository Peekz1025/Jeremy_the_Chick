using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap_Object : MonoBehaviour
{
    
    private void Reset()
    {
        GetComponent<BoxCollider2D>().isTrigger = true;
    }


    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "TheJeremy")
        {
            Debug.Log("gameover");
            //GameOver();
        }
    }
}
