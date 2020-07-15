using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lose_Condition : MonoBehaviour
{
    public GameObject jeremyPrefab;
    public Canvas lose_canvas;

    // Update is called once per frame
    void Update()
    {
        if (jeremyPrefab.transform.position.y < -10)
        {
            lose_canvas.enabled = true;
            Debug.Log("you lost");
        }
    }
}
