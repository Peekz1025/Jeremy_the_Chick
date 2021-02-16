using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]

public class Raycast_Controller : MonoBehaviour
{
    public const float castOriginDepth = 0.03f;
    public int horizontalRayCount = 3;
    public int verticalRayCount = 3;
    public int mercyRayCount = 1;

    [HideInInspector]
    public float horizontalRaySpace;
    [HideInInspector]
    public float verticalRaySpace;

    [HideInInspector]
    public BoxCollider2D myCollider;
    public RaycastOrigins myOrigins;

    // Use this for initialization
    public virtual void Awake()
    {
        myCollider = GetComponent<BoxCollider2D>();
        CalculateRaySpacing();
    }

    public void UpdateRaycastOrigins()
    {
        Bounds bound = myCollider.bounds;
        bound.Expand(castOriginDepth * -2);

        myOrigins.bottomLeft = new Vector2(bound.min.x, bound.min.y);
        myOrigins.bottomRight = new Vector2(bound.max.x, bound.min.y);
        myOrigins.topLeft = new Vector2(bound.min.x, bound.max.y);
        myOrigins.topRight = new Vector2(bound.max.x, bound.max.y);

        CalculateRaySpacing();
    }

    public void CalculateRaySpacing()
    {
        Bounds bound = myCollider.bounds;
        bound.Expand(castOriginDepth * -2);

        horizontalRayCount = Mathf.Clamp(horizontalRayCount, 2, int.MaxValue);
        verticalRayCount = Mathf.Clamp(verticalRayCount, 2, int.MaxValue);

        verticalRaySpace = bound.size.y / (verticalRayCount - 1);
        horizontalRaySpace = bound.size.x / (horizontalRayCount - 1);
    }

    public struct RaycastOrigins
    {
        public Vector2 topLeft, topRight;
        public Vector2 bottomLeft, bottomRight;
    }
}