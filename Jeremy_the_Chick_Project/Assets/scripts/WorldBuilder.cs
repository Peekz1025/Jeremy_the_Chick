using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldBuilder : MonoBehaviour
{
    public int levelSize;
    public Vector3 startPoint;
    private GameObject[] pieces;


    // Start is called before the first frame update
    void Start()
    {
        pieces = Resources.LoadAll<GameObject>("world_pieces/");
        firstBuild(levelSize, startPoint);
    }

    private void buildWorld(int size, Vector2 start)
    {
        WorldPiece prev = null;
        for(int i = 0; i != size; i++)
        {           
            GameObject go = getRandomPiece();
            WorldPiece piece = GameObject.Instantiate(go).GetComponent<WorldPiece>();
            if(i != 0) {
                piece.prev = prev;
                prev.next = piece;
                piece.attachToAnchor(prev.rightAnchor.position);
            }
            else
            {
                piece.attachToAnchor(startPoint);
            }

            prev = piece;
        }
    }

    private GameObject getRandomPiece()
    {
        int id = Random.Range(1, pieces.Length);

        return pieces[id];
    }


    private void firstBuild(int size, Vector2 start)
    {
        GameObject first = pieces[0];
        WorldPiece firstPiece = GameObject.Instantiate(first).GetComponent<WorldPiece>();
        firstPiece.attachToAnchor(startPoint);

        WorldPiece prev = firstPiece;
        for (int i = 0; i != size; i++)
        {
            GameObject go = getRandomPiece();
            WorldPiece piece = GameObject.Instantiate(go).GetComponent<WorldPiece>();
            piece.prev = prev;
            prev.next = piece;
            piece.attachToAnchor(prev.rightAnchor.position);
            prev = piece;
        }
    }



}

/*
could we check the name of the prefab?
have variables if it is up or down. cant go more than 1 up or 1 down
have the flat peice more common than the others so its no so hectic to start
have a defined satrting piece
    
have the update fucntion check if jeremy is within a certain number of pieces to the edge, if so run the build function and reset the var

     
     
*/


