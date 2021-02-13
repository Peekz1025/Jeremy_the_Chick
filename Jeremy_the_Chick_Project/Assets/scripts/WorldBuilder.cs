using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldBuilder : MonoBehaviour
{
    int levelSize = 3;
    public Vector3 buildPoint;
    private GameObject[] pieces;
    //private WorldPiece[] currentWorld;
    //List<WorldPiece> currentWorld;
    List<GameObject> currentWorld;
    int worldTracker;

    //track jeremy postiton
    GameObject Jeremy;
    Vector3 jeremyPosition;

    // Start is called before the first frame update
    void Start()
    {
        currentWorld = new List<GameObject>();
        worldTracker = 0;

        Jeremy = GameObject.FindGameObjectWithTag("TheJeremy");
        jeremyPosition = Jeremy.transform.position;

        pieces = Resources.LoadAll<GameObject>("world_pieces/");
        FirstBuild(levelSize, buildPoint);
    }

    void Update()
    {
        //track jeremy's current position
        jeremyPosition = Jeremy.transform.position;

        //if jeremy is close and its not the first spawn
        if (jeremyPosition.x >= buildPoint.x - 20 && buildPoint.x != -2)
        {
            BuildWorld(levelSize, buildPoint);
        }
        
        //if jeremy is past a world piece, destroy it
        if (jeremyPosition.x >= currentWorld[worldTracker].transform.position.x + 75)
        {
            DestroyWorld();
        }
    }

    private void FirstBuild(int size, Vector2 start)
    {
        GameObject first = pieces[0];
        WorldPiece firstPiece = GameObject.Instantiate(first).GetComponent<WorldPiece>();
        firstPiece.attachToAnchor(start);

        currentWorld.Add(firstPiece.gameObject);

        WorldPiece prev = firstPiece;
        for (int i = 0; i != size; i++)
        {
            GameObject go = GetRandomPiece();
            WorldPiece piece = GameObject.Instantiate(go).GetComponent<WorldPiece>();
            piece.prev = prev;
            prev.next = piece;
            piece.attachToAnchor(prev.rightAnchor.position);
            buildPoint = piece.rightAnchor.position;
            prev = piece;
            currentWorld.Add(piece.gameObject);
        }
    }

    private void BuildWorld(int size, Vector2 start)
    {
        WorldPiece prev = null;
        for (int i = 0; i != size; i++)
        {
            GameObject go = GetRandomPiece();
            WorldPiece piece = GameObject.Instantiate(go).GetComponent<WorldPiece>();
            if (i != 0)
            {
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
            currentWorld.Add(piece.gameObject);
        }
    }
    
    private void DestroyWorld()
    {
        Destroy(currentWorld[worldTracker]);
        worldTracker++;
    }

    private GameObject GetRandomPiece()
    {
        int id = Random.Range(1, pieces.Length);
        return pieces[id];
    }

}