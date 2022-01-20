using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [SerializeField]
    private float moveForce = 10f;
    [SerializeField]
    

    private float movementX;

    public Rigidbody2D myBody;

    private SpriteRenderer sr;

    private Animator anim;
    private string run_ANIMATION = "run";

    private bool isGrounded;
    private string GROUND_TAG = "Ground";

    AudioSource audioSrc;
    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        sr = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    void Update()
    {
        PlayerMoveKeyboard();
        AnimatePlayer();
        
        float speed = Mathf.Abs(movementX);
        
        anim.SetFloat("speed",speed);
        

    }

    void PlayerMoveKeyboard()
    {

        movementX = Input.GetAxisRaw("Horizontal");
        //Debug.Log(movementX);
        transform.position += new Vector3(movementX, 0f, 0f) * moveForce * Time.deltaTime;
    }

    void AnimatePlayer() {

        // we are going to the right side
        if (movementX > 0)
        {
            //TODO place run sound
            anim.SetBool("run", true);
            sr.flipX = false;
            if (!audioSrc.isPlaying)
                audioSrc.Play();
        }
        else if (movementX < 0)
        {
            // we are going to the left side
            //TODO place run sound
            anim.SetBool("run", true);
            sr.flipX = true;
            if (!audioSrc.isPlaying)
                audioSrc.Play();
        }     
        else
        {
            anim.SetBool("run", false);
            audioSrc.Stop();
        }   

    }


} // class