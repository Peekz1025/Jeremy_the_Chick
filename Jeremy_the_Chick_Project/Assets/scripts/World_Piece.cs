using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World_Piece : MonoBehaviour
{
    [HideInInspector]
    public Transform leftAnchor;
    [HideInInspector]
    public Transform rightAnchor;

    [HideInInspector]
    public World_Piece prev;
    [HideInInspector]
    public World_Piece next;

    // Start is called before the first frame update
    void Awake()
    {
       leftAnchor = transform.Find("AnchorLeft");
       rightAnchor = transform.Find("AnchorRight");
    }

    public void attachToAnchor(Vector3 anchor)
    {
        if(leftAnchor == null)
        {
            Debug.LogError("Attempted to anchor world piece without initialized anchor locations.");
        }
        Vector3 m = leftAnchor.localPosition * -1f;

        transform.position = anchor + m;
    }
}
