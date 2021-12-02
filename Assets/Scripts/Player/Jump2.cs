using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump2 : MonoBehaviour
{
    private Rigidbody2D playerRB;
    float force = 28f;
    float force2 = 48f;
    bool isgrounded = false;


    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isgrounded == true)
            { playerRB.velocity = new Vector3(playerRB.velocity.x, force); }
            isgrounded = false;

        }
    }
    void OnTriggerEnter(Collider theCollision)
    {
      if(theCollision.gameObject.tag == "floor")
       {
        isgrounded = true;
       }
      else
       {
        isgrounded = false;
       }


    }


    public void OnJumpButton() // like this
    {
      if (isgrounded == true)
       {
        playerRB.velocity = new Vector3(playerRB.velocity.x, force);
       }
      isgrounded = false;


    }
}
