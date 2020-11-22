using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyBuilder : MonoBehaviour
{
    public Vector3 buildPoint;
    private GameObject[] pieces;

    // Start is called before the first frame update
    void Start()
    {
        pieces = Resources.LoadAll<GameObject>("sky_pieces/");
        buildWorldParallax(new Vector2(-50, 1.5f));
    }

    private void buildWorldParallax(Vector2 start)
    {
        WorldPiece prev = null;
        for (int i = 0; i < 3; i++)
        {
            GameObject go = getRandomPiece();
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
        }
    }

    private GameObject getRandomPiece()
    {
        int id = Random.Range(0, pieces.Length);
        return pieces[id];
    }

}