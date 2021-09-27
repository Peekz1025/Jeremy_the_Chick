using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Movement : MonoBehaviour
{
    Vector3 ipadPos;
    float cameraRatio;

    void Start()
    {
        cameraRatio = Camera.main.aspect;
        
        //for some reason X is 2 more than it shows in inspector
        ipadPos = new Vector3(6, 0.8f, -10);

        if (cameraRatio <= 1.4)
        {
            transform.position = ipadPos;
        }
    }
}
