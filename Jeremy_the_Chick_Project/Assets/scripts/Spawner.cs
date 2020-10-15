using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject prefab;
    public Camera mainCamera;

    // Update is called once per frame
    public void SpawnObject()
    {
        //Input.touchCount > 0 //all touch presses
        /*if (Input.GetButtonDown("Fire1"))
        {
            Vector3 touchPosition = mainCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1f));
            Instantiate(prefab, touchPosition, Quaternion.identity);
            Debug.Log("here");
        }*/

        // mouse click
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 touchPosition = mainCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1f));
            Instantiate(prefab, touchPosition, Quaternion.identity);
        }

    }
}



