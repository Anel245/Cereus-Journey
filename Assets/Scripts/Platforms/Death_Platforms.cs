using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death_Platforms : MonoBehaviour
{

    private void Start()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("deathCollision");
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<LifeCount>().KillPlayer();





        }


    }
}
