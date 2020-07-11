using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    protected Collisions movementController;

    private Vector2 _velocity;
    public Vector2 velocity { get { return _velocity; } set { setVelocity(value); } }

    public bool enabled {get; private set;}

    protected void Start()
    {
        enabled = true;
    }

    public void setVelocity(Vector2 newVelocity)
    {
        _velocity = newVelocity;
    }

    public void addVelocity(Vector2 newVelocity)
    {
        _velocity = new Vector2(_velocity.x+newVelocity.x, _velocity.y+newVelocity.y);
    }

    protected void applyVelocity() 
    {
       movementController.applyVelocity(_velocity * Time.deltaTime);
       if(movementController.data.down.hit) _velocity.y = 0;

    }
}
