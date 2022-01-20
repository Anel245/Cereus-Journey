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


    private float movementY;
    public float jumpVelocity = 10f;





    private void Awake()
    {
        rigidbody2d = transform.GetComponent<Rigidbody2D>();
        boxCollider2d = transform.GetComponent<BoxCollider2D>();
        anim = transform.GetComponent<Animator>();

    }
    void Update()
    {
        PlayerMoveKeyboard();

        float speed = Mathf.Abs(movementY);
        anim.SetFloat("speed", speed);


    }

    void PlayerMoveKeyboard()
    {

        movementY = Input.GetAxisRaw("Vertical");

        transform.position += new Vector3(0f, movementY, 0f) * Time.deltaTime;
    }


    // Update is called once per frame
    private void FixedUpdate()
    {

            if (Input.GetKey(KeyCode.Space) && !isJumping)
        {
            SoundManager.PlaySound("Jump");
            print("jump");
            anim.SetTrigger("takeOf");

            //TODO place jump sound
           
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
            //Place landing sound
            
            print("landing");
            
            isJumping = false;
            anim.SetBool("isJumping", false);
           
        }

    }



}
