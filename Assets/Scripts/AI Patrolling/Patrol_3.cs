using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol_3 : MonoBehaviour
{

    [SerializeField] float moveSpeed = 1f;
    Rigidbody2D myRigidbody;
    
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {
        if(IsFacingRight())
        {
            myRigidbody.velocity = new Vector2(moveSpeed, 0f);
        }
        else
        {
            myRigidbody.velocity = new Vector2(-moveSpeed, 0f);
        }
    }

    private bool IsFacingRight()
    {
        return transform.localScale.x > Mathf.Epsilon;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("It works");
        float direction = IsFacingRight() ? 0.14f : -0.14f;
        transform.localScale = new Vector2(direction, transform.localScale.y);
        





    }


}
