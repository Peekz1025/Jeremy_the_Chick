using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree_Color_Randomizer : MonoBehaviour
{
    GameObject[] treeSquare;
    GameObject[] treeThic;
    GameObject[] treeRectangle;
    GameObject[] treeLong;
    GameObject[] treeSmol;

    public Sprite squareSummer1;
    public Sprite thicSummer1;
    public Sprite rectSummer1;
    public Sprite longSummer1;
    public Sprite smolSummer1;

    public Sprite squareSummer2;
    public Sprite thicSummer2;
    public Sprite rectSummer2;
    public Sprite longSummer2;
    public Sprite smolSummer2;

    public Sprite squareAutumn1;
    public Sprite thicAutumn1;
    public Sprite rectAutumn1;
    public Sprite longAutumn1;
    public Sprite smolAutumn1;

    public Sprite squareAutumn2;
    public Sprite thicAutumn2;
    public Sprite rectAutumn2;
    public Sprite longAutumn2;
    public Sprite smolAutumn2;


    public void RandomizeColors(World_Piece worldPiece)
    {
        /*
        treeSquare = GameObject.FindGameObjectsWithTag("TreeSquare");
        treeThic = GameObject.FindGameObjectsWithTag("TreeThic");
        treeRectangle = GameObject.FindGameObjectsWithTag("TreeRectangle");
        treeLong = GameObject.FindGameObjectsWithTag("TreeLong");
        treeSmol = GameObject.FindGameObjectsWithTag("TreeSmol");

        float right = worldPiece.rightAnchor.transform.position.x;
        float left = worldPiece.leftAnchor.transform.position.x;

        if (PlayerPrefs.GetString("Background") == "summer")
        {
            foreach (GameObject tree in treeSquare)
            {
                Vector3 treePosition = tree.transform.position;
                SpriteRenderer treeSprite = tree.GetComponent<SpriteRenderer>();

                if (treePosition.x < right && treePosition.x > left)
                {
                    if(Random.Range(0,100) >= 50)
                        treeSprite.sprite = squareSummer1;
                    else
                        treeSprite.sprite = squareSummer2;
                }
            }

            foreach (GameObject tree in treeThic)
            {
                Vector3 treePosition = tree.transform.position;
                SpriteRenderer treeSprite = tree.GetComponent<SpriteRenderer>();

                if (treePosition.x < right && treePosition.x > left)
                {
                    if (Random.Range(0, 100) >= 50)
                        treeSprite.sprite = thicSummer1;
                    else
                        treeSprite.sprite = thicSummer2;
                }
            }

            foreach (GameObject tree in treeRectangle)
            {
                Vector3 treePosition = tree.transform.position;
                SpriteRenderer treeSprite = tree.GetComponent<SpriteRenderer>();

                if (treePosition.x < right && treePosition.x > left)
                {
                    if (Random.Range(0, 100) >= 50)
                        treeSprite.sprite = rectSummer1;
                    else
                        treeSprite.sprite = rectSummer2;
                }
            }

            foreach (GameObject tree in treeLong)
            {
                Vector3 treePosition = tree.transform.position;
                SpriteRenderer treeSprite = tree.GetComponent<SpriteRenderer>();

                if (treePosition.x < right && treePosition.x > left)
                {
                    if (Random.Range(0, 100) >= 50)
                        treeSprite.sprite = longSummer1;
                    else
                        treeSprite.sprite = longSummer2;
                }
            }

            foreach (GameObject tree in treeSmol)
            {
                Vector3 treePosition = tree.transform.position;
                SpriteRenderer treeSprite = tree.GetComponent<SpriteRenderer>();

                if (treePosition.x < right && treePosition.x > left)
                {
                    if (Random.Range(0, 100) >= 50)
                        treeSprite.sprite = smolSummer1;
                    else
                        treeSprite.sprite = smolSummer2;
                }
            }
        }


        if (PlayerPrefs.GetString("Background") == "autumn")
        {
            foreach (GameObject tree in treeSquare)
            {
                Vector3 treePosition = tree.transform.position;
                SpriteRenderer treeSprite = tree.GetComponent<SpriteRenderer>();

                if (treePosition.x < right && treePosition.x > left)
                {
                    if (Random.Range(0, 100) >= 50)
                        treeSprite.sprite = squareAutumn1;
                    else
                        treeSprite.sprite = squareAutumn2;
                }
            }

            foreach (GameObject tree in treeThic)
            {
                Vector3 treePosition = tree.transform.position;
                SpriteRenderer treeSprite = tree.GetComponent<SpriteRenderer>();

                if (treePosition.x < right && treePosition.x > left)
                {
                    if (Random.Range(0, 100) >= 50)
                        treeSprite.sprite = thicAutumn1;
                    else
                        treeSprite.sprite = thicAutumn2;
                }
            }

            foreach (GameObject tree in treeRectangle)
            {
                Vector3 treePosition = tree.transform.position;
                SpriteRenderer treeSprite = tree.GetComponent<SpriteRenderer>();

                if (treePosition.x < right && treePosition.x > left)
                {
                    if (Random.Range(0, 100) >= 50)
                        treeSprite.sprite = rectAutumn1;
                    else
                        treeSprite.sprite = rectAutumn2;
                }
            }

            foreach (GameObject tree in treeLong)
            {
                Vector3 treePosition = tree.transform.position;
                SpriteRenderer treeSprite = tree.GetComponent<SpriteRenderer>();

                if (treePosition.x < right && treePosition.x > left)
                {
                    if (Random.Range(0, 100) >= 50)
                        treeSprite.sprite = longAutumn1;
                    else
                        treeSprite.sprite = longAutumn2;
                }
            }

            foreach (GameObject tree in treeSmol)
            {
                Vector3 treePosition = tree.transform.position;
                SpriteRenderer treeSprite = tree.GetComponent<SpriteRenderer>();

                if (treePosition.x < right && treePosition.x > left)
                {
                    if (Random.Range(0, 100) >= 50)
                        treeSprite.sprite = smolAutumn1;
                    else
                        treeSprite.sprite = smolAutumn2;
                }
            }
        }*/
    }
}
