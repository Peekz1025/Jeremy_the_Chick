using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sky_Builder : MonoBehaviour
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
        World_Piece prev = null;
        for (int i = 0; i < 3; i++)
        {
            GameObject go = getRandomPiece();
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
        }
    }

    private GameObject getRandomPiece()
    {
        int id = Random.Range(0, pieces.Length);
        return pieces[id];
    }

}