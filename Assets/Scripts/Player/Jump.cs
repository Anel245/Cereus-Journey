using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] private LayerMask platformsLayerMask;
    private Rigidbody2D rigidbody2d;
    private BoxCollider2D boxCollider2d;
    private bool isJumping;
    private Animator anim;

    [SerializeField]
    private float jumpForce = 11f;





    private void Awake()
    {
        rigidbody2d = transform.GetComponent<Rigidbody2D>();
        boxCollider2d = transform.GetComponent<BoxCollider2D>();
        anim = transform.GetComponent<Animator>();
    }


    // Update is called once per frame
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            anim.SetTrigger("takeOf");
            float jumpVelocity = 10f;
            rigidbody2d.velocity = Vector2.up * jumpVelocity;
            isJumping = true;
        }

        else if (isJumping) 
        {
            anim.SetBool("isJumping", true);
        }



    }


    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            print("landing");
            isJumping = false;
            anim.SetBool("isJumping", false);
        }

    }



}
