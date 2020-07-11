using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchDrag : TouchSprite
{
    // Update is called once per frame
    void Update()
    {
        TouchInput(GetComponent<BoxCollider2D>());
    }

    void OnFirstTouch()
    {
        Vector3 pos;
        pos = new Vector3(Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position).x, Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position).y, transform.position.z);
        transform.position = pos;
    }
}
