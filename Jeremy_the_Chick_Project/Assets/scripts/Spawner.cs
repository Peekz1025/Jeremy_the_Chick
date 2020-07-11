using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject prefab;
    public GameObject button;
    public Camera mainCamera;

    // Update is called once per frame
    public void SpawnObject()
    {
        //dont do if the mouse overlaps the button.
        //set it up as on the click, this happens


        if (Input.GetButtonDown("Fire1"))// && Input.mousePosition.x == button.GetComponent(ImagePosition).x
             //Input.GetMouseButtonDown(0)
             //Input.touchCount > 0
        {
            Vector3 touchPosition = mainCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1f));
            Instantiate(prefab, touchPosition, Quaternion.identity);
            
        }







        /*

        //Input.touches.any(x => x.phase == TouchPhase.Began;
        //Input.GetButtonDown("Fire1");

        Collider2D buttonCollider = button.GetComponent<BoxCollider2D>();

        if (Input.GetButtonDown("Fire1"))
        {
            if (buttonCollider == Physics2D.OverlapPoint(Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position)))
            {
                
            }

            if (Input.touchCount > 1)
            {
                if (buttonCollider == Physics2D.OverlapPoint(Camera.main.ScreenToWorldPoint(Input.GetTouch(1).position)))
                {
                   
                }
            }
        }
        */




    }
}



