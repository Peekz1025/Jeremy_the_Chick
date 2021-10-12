﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World_Builder : MonoBehaviour
{
    public int levelSize = 2;
    public Vector3 buildPoint;
    private GameObject[] pieces;
    public List<GameObject> currentWorld;
    int worldTracker;

    Object_Spawner spawnerScript;
    Tree_Color_Randomizer treeRandomizer;

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

        
        if (PlayerPrefs.GetString("Background") == "summer")
            pieces = Resources.LoadAll<GameObject>("summer/world_pieces/");
        if (PlayerPrefs.GetString("Background") == "autumn")
            pieces = Resources.LoadAll<GameObject>("autumn/world_pieces/");
        
        //pieces = Resources.LoadAll<GameObject>("world_pieces_tests/");

        FirstBuild(levelSize, buildPoint);

        spawnerScript = this.GetComponent<Object_Spawner>();
        treeRandomizer = this.GetComponent<Tree_Color_Randomizer>();
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
        if (jeremyPosition.x >= currentWorld[worldTracker].transform.position.x + 100)
        {
            DestroyWorld();
        }
    }

    private void FirstBuild(int size, Vector2 start)
    {
        GameObject first = pieces[0];
        World_Piece firstPiece = GameObject.Instantiate(first).GetComponent<World_Piece>();
        firstPiece.attachToAnchor(start);

        currentWorld.Add(firstPiece.gameObject);

        World_Piece prev = firstPiece;
        for (int i = 0; i != size; i++)
        {
            GameObject go = GetRandomPiece();
            World_Piece piece = GameObject.Instantiate(go).GetComponent<World_Piece>();
            piece.prev = prev;
            prev.next = piece;
            piece.attachToAnchor(prev.rightAnchor.position);
            buildPoint = piece.rightAnchor.position;
            prev = piece;
            currentWorld.Add(piece.gameObject);

            //treeRandomizer.RandomizeColors(piece);
        }
    }

    private void BuildWorld(int size, Vector2 start)
    {
        World_Piece prev = null;
        for (int i = 0; i < size; i++)
        {
            GameObject go = GetRandomPiece();
            World_Piece piece = GameObject.Instantiate(go).GetComponent<World_Piece>();
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

            // spawn eggs & fire
            spawnerScript.SpawnEggs(piece);
            spawnerScript.SpawnFire(piece, jeremyPosition);

            //randomize colors of trees
            treeRandomizer.RandomizeColors(piece);
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