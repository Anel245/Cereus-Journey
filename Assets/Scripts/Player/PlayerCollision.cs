using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour

{
    private Animator anim;
    private string hit_ANIMATION = "Hit";

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    public void GoToWin()
    {
        SceneManager.LoadScene("Win");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Enemy")
        {
            anim.SetTrigger(hit_ANIMATION);
            GetComponent<LifeCount>().LoseLife();


        }
        if (collision.transform.tag == "Win")
        {
            Debug.Log("THIS SHIT SHOULD WORK!");
            //GetComponent<MainMenu>().GoToWin();
            GoToWin();


        }


    }




}
