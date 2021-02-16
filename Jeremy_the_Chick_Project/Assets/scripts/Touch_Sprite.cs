﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch_Sprite : MonoBehaviour
{
    
    public static bool guiTouch = false;

    public void TouchInput(Collider2D collider)
    {
        if (Input.touchCount > 0)
        {
            if(collider == Physics2D.OverlapPoint(Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position)))
            {
                switch (Input.GetTouch(0).phase)
                {
                    case TouchPhase.Began:
                        SendMessage("OnFirstTouchBegan", SendMessageOptions.DontRequireReceiver);
                        SendMessage("OnFirstTouch", SendMessageOptions.DontRequireReceiver);
                        guiTouch = true;
                        break;
                    case TouchPhase.Stationary:
                        SendMessage("OnFirstTouchStayed", SendMessageOptions.DontRequireReceiver);
                        SendMessage("OnFirstTouch", SendMessageOptions.DontRequireReceiver);
                        guiTouch = true;
                        break;
                    case TouchPhase.Moved:
                        SendMessage("OnFirstTouchMoved", SendMessageOptions.DontRequireReceiver);
                        SendMessage("OnFirstTouch", SendMessageOptions.DontRequireReceiver);
                        guiTouch = true;
                        break;
                    case TouchPhase.Ended:
                        SendMessage("OnFirstTouchEnded", SendMessageOptions.DontRequireReceiver);
                        guiTouch = false;
                        break;
                }
            }

            if (Input.touchCount > 1)
            {
                if (collider == Physics2D.OverlapPoint(Camera.main.ScreenToWorldPoint(Input.GetTouch(1).position)))
                {
                    switch (Input.GetTouch(1).phase)
                    {
                        case TouchPhase.Began:
                            SendMessage("OnSecondTouchBegan", SendMessageOptions.DontRequireReceiver);
                            SendMessage("OnSecondTouch", SendMessageOptions.DontRequireReceiver);
                            break;
                        case TouchPhase.Stationary:
                            SendMessage("OnSecondTouchStayed", SendMessageOptions.DontRequireReceiver);
                            SendMessage("OnSecondtTouch", SendMessageOptions.DontRequireReceiver);
                            break;
                        case TouchPhase.Moved:
                            SendMessage("OnSecondTouchMoved", SendMessageOptions.DontRequireReceiver);
                            SendMessage("OnSecondTouch", SendMessageOptions.DontRequireReceiver);
                            break;
                        case TouchPhase.Ended:
                            SendMessage("OnSecondTouchEnded", SendMessageOptions.DontRequireReceiver);
                            break;
                    }
                }
            }
        }
    }

    public void MouseInput(Collider2D collider)
    {
        //if (Input.GetMouseButtonDown())
        //{
            if (collider == Physics2D.OverlapPoint(Camera.main.ScreenToWorldPoint(Input.mousePosition)))
            {
                switch (Input.GetTouch(0).phase)
                {
                    case TouchPhase.Began:
                        SendMessage("OnFirstTouchBegan", SendMessageOptions.DontRequireReceiver);
                        SendMessage("OnFirstTouch", SendMessageOptions.DontRequireReceiver);
                        guiTouch = true;
                        break;
                    case TouchPhase.Stationary:
                        SendMessage("OnFirstTouchStayed", SendMessageOptions.DontRequireReceiver);
                        SendMessage("OnFirstTouch", SendMessageOptions.DontRequireReceiver);
                        guiTouch = true;
                        break;
                    case TouchPhase.Moved:
                        SendMessage("OnFirstTouchMoved", SendMessageOptions.DontRequireReceiver);
                        SendMessage("OnFirstTouch", SendMessageOptions.DontRequireReceiver);
                        guiTouch = true;
                        break;
                    case TouchPhase.Ended:
                        SendMessage("OnFirstTouchEnded", SendMessageOptions.DontRequireReceiver);
                        guiTouch = false;
                        break;
                }
            }

            if (Input.touchCount > 1)
            {
                if (collider == Physics2D.OverlapPoint(Camera.main.ScreenToWorldPoint(Input.mousePosition)))
                {
                    switch (Input.GetTouch(1).phase)
                    {
                        case TouchPhase.Began:
                            SendMessage("OnSecondTouchBegan", SendMessageOptions.DontRequireReceiver);
                            SendMessage("OnSecondTouch", SendMessageOptions.DontRequireReceiver);
                            break;
                        case TouchPhase.Stationary:
                            SendMessage("OnSecondTouchStayed", SendMessageOptions.DontRequireReceiver);
                            SendMessage("OnSecondtTouch", SendMessageOptions.DontRequireReceiver);
                            break;
                        case TouchPhase.Moved:
                            SendMessage("OnSecondTouchMoved", SendMessageOptions.DontRequireReceiver);
                            SendMessage("OnSecondTouch", SendMessageOptions.DontRequireReceiver);
                            break;
                        case TouchPhase.Ended:
                            SendMessage("OnSecondTouchEnded", SendMessageOptions.DontRequireReceiver);
                            break;
                    }
                }
            }
        //}
    }


}
