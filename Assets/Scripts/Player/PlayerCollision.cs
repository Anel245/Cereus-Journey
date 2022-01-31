using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour

{
    private Animator anim;
    private string hit_ANIMATION = "Hit";

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Enemy")
        {
            anim.SetTrigger(hit_ANIMATION);
            GetComponent<LifeCount>().LoseLife();


        }

        
    }




}
