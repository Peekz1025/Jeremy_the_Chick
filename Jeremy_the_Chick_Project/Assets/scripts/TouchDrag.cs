using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchDrag : TouchSprite
{
    private bool isDragging = false;

    // Update is called once per frame
    void Update()
    {
        //TouchInput(GetComponent<BoxCollider2D>());

        if (isDragging)
        {
            Vector3 pos = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, transform.position.z) - transform.position;
            transform.Translate(pos);
        }
    }

    void OnFirstTouch()
    {
        //Vector3 pos = new Vector3(Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position).x, Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position).y, transform.position.z);
        //transform.position = pos;

        //Vector3 pos = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, transform.position.z) - transform.position;
        //transform.Translate(pos);
    }


    private void OnMouseDown()
    {
        isDragging = true;
    }

    private void OnMouseUp()
    {
        isDragging = false;
    }

}
