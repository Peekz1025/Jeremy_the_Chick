using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Spawner : MonoBehaviour
{
    public GameObject egg;
    public GameObject fire;

    public void SpawnEggs(World_Piece worldPiece)
    {
        // 75% of the time, spawn eggs
        if (Random.Range(1, 100) <= 80)
        {
            //make 2 eggs
            for (int numEgg = 0; numEgg < Random.Range(1, 4); numEgg++)
            {
                Vector3 right = worldPiece.rightAnchor.position;
                Vector3 left = worldPiece.leftAnchor.position;

                //if there is no hieght change in the world piece, spawn eggs
                if (right.y == left.y)
                {
                    Vector3 eggLocation = new Vector3(Random.Range(left.x, right.x), Random.Range(left.y + 2, right.y + 5), 0f);
                    Instantiate(egg, eggLocation, Quaternion.identity);
                }
            }
        }
    }

    public void SpawnFire(World_Piece worldPiece)
    {
        // 50% of the time, spawn eggs
        if (Random.Range(1, 100) <= 100)
        {
            for (int numFire = 0; numFire < Random.Range(1, 2); numFire++)
            {
                Vector3 right = worldPiece.rightAnchor.position;
                Vector3 left = worldPiece.leftAnchor.position;

                //if there is no hieght change in the world piece, spawn eggs
                if (right.y == left.y)
                {
                    Vector3 fireLocation = new Vector3(Random.Range(left.x, right.x), left.y + 0.95f, 0f);
                    GameObject newFire = Instantiate(fire, fireLocation, Quaternion.identity);
                    
                    Fire fireScript = newFire.GetComponent<Fire>();
                    while (fireScript.stuckInGround)
                    {
                        newFire.transform.position = new Vector3(newFire.transform.position.x, newFire.transform.position.y + 0.1f, newFire.transform.position.z);
                    }

                }
            }
        }
    }
}
