using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : RaycastController
{
    private BoxCollider2D hitBox;
    public CollisionDataSum data;

    public LayerMask collisionMask;

    public int stepSize;

    public struct CollisionDataSum
    {  
        public CollisionData left;
        public CollisionData up;
        public CollisionData down;
        public CollisionData right;

        public void Reset()
        {
            left.Reset();
            up.Reset();
            down.Reset();
            right.Reset();
        }
    }

    public struct CollisionData
    {
        public bool hit;
        public int layer;

        public void Reset()
        {
            layer = 0;
            hit = false;
        }
    }

    public void applyVelocity(Vector2 velocity)
    {
        data.Reset();               // Reset the collision data
        UpdateRaycastOrigins();     // Update the raycast source positions
			
        // This handles the most simple parts of the movement; it checks if basic translation is valid and applies it if so while gathering data for more sophisticated logic.
        basicCheckAndMove(ref velocity);
    }

    void basicCheckAndMove(ref Vector2 velocity)
    {
        // Check the current course of horizontal movement and update to account for solid objects.
        if (velocity.x < 0)
            CheckCollisions(ref velocity.x, ref data.left, verticalRayCount, myOrigins.bottomLeft, Vector2.up * verticalRaySpace, new Vector2(-1, 0), collisionMask);
        else if (velocity.x > 0)
            CheckCollisions(ref velocity.x, ref data.right, verticalRayCount, myOrigins.bottomRight, Vector2.up * verticalRaySpace, new Vector2(1, 0), collisionMask);

        velocity.x = (float)System.Math.Round(velocity.x, 3); // Helps eliminates insignificant translations and microclipping
        // Apply the acceptable horizontal movement and update the origins before checking the vertical movement
        transform.Translate(new Vector2(velocity.x, 0));
        UpdateRaycastOrigins();

        if (velocity.y < 0)
            CheckCollisions(ref velocity.y, ref data.down, horizontalRayCount, myOrigins.bottomLeft, Vector2.right * horizontalRaySpace, new Vector2(0, -1), collisionMask);
        else if (velocity.y > 0)
            CheckCollisions(ref velocity.y, ref data.up, horizontalRayCount, myOrigins.topLeft, Vector2.right * horizontalRaySpace, new Vector2(0, 1), collisionMask);

        // Apply the acceptable horizontal movement and update the origins before checking the vertical movement
        velocity.y = (float)System.Math.Round(velocity.y, 3); // Helps eliminates insignificant translations and microclipping
        transform.Translate(new Vector2(0, velocity.y));
        UpdateRaycastOrigins();
    }


    void CheckCollisions(ref float velocity, ref CollisionData data, int rayCount, Vector2 rayOrigin, Vector2 raySpacing, Vector2 rayDirection, LayerMask mask)
    {
        float velocityOriginal = velocity;
        float rayLength = Mathf.Abs(velocity) + castOriginDepth;

        bool stepStopped = false;
        bool stepLegal = true;
        int stepCount = 0;    

        // We send out rays evenly distributed across the length of the collider in this dimension.
        for (int i = 0; i < rayCount; i++)
        {
            RaycastHit2D hit = Physics2D.Raycast(rayOrigin + (raySpacing * i), rayDirection, rayLength, mask);
            Debug.DrawRay(rayOrigin + (raySpacing * i), rayDirection*rayLength, Color.red);

            // If this ray hit a solid object...
            if (hit)
            {
                if(!stepStopped) stepCount++;
                else stepLegal = false;

                // ....Don't totally recall why this is here? Guessing it probably stops you from getting locked in place if you end up in a wall.
                if (hit.distance == 0)
                    continue;
         
                // Mark that this side of the collider hit a solid object
                data.hit = true;
                data.layer = hit.collider.gameObject.layer;

                // Record the remaining velocity
                velocity = Mathf.Clamp((hit.distance - castOriginDepth), 0, float.MaxValue) * (float)(rayDirection.x + rayDirection.y);

                // Future rays need to only check up to the distance of where we hit the object, since we won't go any further than that.
                rayLength = hit.distance;
            }
            else
            {
                stepStopped = true;
            }
        }
        if(stepLegal && stepCount < stepSize)
        {
            Vector2 trans = ((raySpacing*(stepCount)) * (new Vector2(-Mathf.Abs(rayDirection.y), Mathf.Abs(rayDirection.x))));
            transform.position += new Vector3(trans.x, trans.y, 0);
            UpdateRaycastOrigins();
            velocity=velocityOriginal;
            CheckCollisions(ref velocity, ref data, rayCount, rayOrigin, raySpacing, rayDirection, mask);
        }
    }
}
