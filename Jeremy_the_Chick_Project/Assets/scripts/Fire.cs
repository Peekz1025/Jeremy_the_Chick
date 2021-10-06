using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public bool stuckInGround = false;


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Water")
        {
            //Debug.Log("collided with water");
            Destroy(this.gameObject);
        }

        if (collision.gameObject.tag == "Rock")
        {
            //Debug.Log("collided with rock");
            //need to check a specific side of the rock
            Destroy(this.gameObject);
        }

        if (collision.gameObject.tag == "Log")
        {
            //Debug.Log("collided with log");
            Destroy(collision.gameObject);
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
}
