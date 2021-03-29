using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    GameObject cam;

    public float relativeMoveX = .3f;
    public float relativeMoveY = .9f;

    private float length = 50;
    private float startPos;

    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.FindGameObjectWithTag("MainCamera");

        startPos = transform.position.x;
        length = 50;
    }

    // Update is called once per frame
    void Update()
    {
        float temp = (cam.transform.position.x * (1 - relativeMoveX));
        float dist = (cam.transform.position.x * relativeMoveX);

        transform.position = new Vector2(startPos + dist, cam.transform.position.y ); //* relativeMoveY

        if (temp > startPos + length + 10)
            startPos += length * 3;
        else if (temp < startPos - length + 10)
            startPos -= length * 3;
    }
}
