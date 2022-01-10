using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPatrol : MonoBehaviour
{
    public float walkSpeed;

    [HideInInspector]
    public bool mustPatrol;
    private bool mustTurn;

    public Rigidbody2D rb;
    public LayerMask PlatformsLayer;
    public Collider2D bodyCollider;
    void Start()
    {
        mustPatrol = true;
    }


    void Update()
    {
        if (mustPatrol)
        {
            Patrol();
        }
    }

    void Patrol()
    {
        
        if (mustTurn || bodyCollider.IsTouchingLayers(PlatformsLayer))
        
        {
            print("string");
            Flip();
        }

        rb.velocity = new Vector2(-walkSpeed * Time.fixedDeltaTime, rb.velocity.y);

    }

    void Flip()
    {
        mustPatrol = false;
        transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
        walkSpeed *= -1;
        mustPatrol = true;
    }



}
