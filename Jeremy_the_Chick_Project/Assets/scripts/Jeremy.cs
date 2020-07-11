using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jeremy : Entity
{
    bool right = true;

    // Start is called before the first frame update
    void Awake()
    {
        movementController = GetComponent<Collisions>();
    }

    // Update is called once per frame
    void Update()
    {
        if(right)
        {
            setVelocity(new Vector2(2, velocity.y));
            if(movementController.data.right.hit) right = false;
        }
        else
        {
            setVelocity(new Vector2(-2, velocity.y));
            if(movementController.data.left.hit) right = true;
        }
    }

    private void LateUpdate()
    {       
        applyVelocity();
    }
}
