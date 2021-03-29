using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg_Spawner : MonoBehaviour
{
    public GameObject egg;

    public void SpawnEggs(World_Piece worldPiece)
    {
        // 75% of the time, spawn eggs
        if (Random.Range(1, 100) <= 75)
        {
            //make 2 eggs
            for (int numEgg = 0; numEgg < Random.Range(1, 3); numEgg++)
            {
                Vector3 right = worldPiece.rightAnchor.position;
                Vector3 left = worldPiece.leftAnchor.position;

                //if there is no hieght change in the world piece, spawn eggs
                if (right.y == left.y)
                {
                    Vector3 eggLocation = new Vector3(Random.Range(left.x, right.x), Random.Range(left.y + 1, right.y + 5), 0f);
                    Instantiate(egg, eggLocation, Quaternion.identity);
                }
            }
        }
    }
}
