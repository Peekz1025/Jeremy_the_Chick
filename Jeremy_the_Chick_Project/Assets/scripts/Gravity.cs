using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Entity))]

public class Gravity : MonoBehaviour
{
    Entity target;

    public float accelerationDueToGravity;
	public float maximumVelocityDueToGravity;

    private void Awake()
    {
        target = GetComponent<Entity>();
    }

    // Update is called once per frame
    void Update()
    {
        if(target.enabled) // Things like screen transitions can disable an entity. Their gravity should only apply if they're active.
        {
            Vector2 v = new Vector2(0, -1 * accelerationDueToGravity * Time.deltaTime);
		    if(target.velocity.y >= -maximumVelocityDueToGravity) target.addVelocity(new Vector2(v.x, v.y));
        }
    }
}
