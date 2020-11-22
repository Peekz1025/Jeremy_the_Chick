using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldBuilder : MonoBehaviour
{
    public int levelSize;
    public Vector3 buildPoint;
    private GameObject[] pieces;

    //track jeremy postiton
    GameObject Jeremy;
    Vector3 jeremyPosition;

    // Start is called before the first frame update
    void Start()
    {
        Jeremy = GameObject.FindGameObjectWithTag("TheJeremy");
        jeremyPosition = Jeremy.transform.position;

        pieces = Resources.LoadAll<GameObject>("world_pieces/");
        firstBuild(levelSize, buildPoint);
    }

    void Update()
    {
        //track jeremy's current position
        jeremyPosition = Jeremy.transform.position;

        //if jeremy is close and its not the first spawn
        if (jeremyPosition.x >= buildPoint.x - 20 && buildPoint.x != -2)
        {
            buildWorld(levelSize, buildPoint);
        }
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
                buildPoint = piece.rightAnchor.position;
            }
            else
            {
                piece.attachToAnchor(start);
            }
            prev = piece;
        }
    }

    private void firstBuild(int size, Vector2 start)
    {
        GameObject first = pieces[0];
        WorldPiece firstPiece = GameObject.Instantiate(first).GetComponent<WorldPiece>();
        firstPiece.attachToAnchor(start);

        WorldPiece prev = firstPiece;
        for (int i = 0; i != size; i++)
        {
            GameObject go = getRandomPiece();
            WorldPiece piece = GameObject.Instantiate(go).GetComponent<WorldPiece>();
            piece.prev = prev;
            prev.next = piece;
            piece.attachToAnchor(prev.rightAnchor.position);
            buildPoint = piece.rightAnchor.position;
            prev = piece;
        }
    }

    private GameObject getRandomPiece()
    {
        int id = Random.Range(1, pieces.Length);
        return pieces[id];
    }

}