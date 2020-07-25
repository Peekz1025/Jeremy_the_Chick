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
        buildWorld(levelSize, startPoint);
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
        int id = Random.Range(0, pieces.Length);

        return pieces[id];
    }
}
