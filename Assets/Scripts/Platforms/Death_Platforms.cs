using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death_Platforms : MonoBehaviour
{
    public int livesRemaining;
    [SerializeField] LifeCount lifeCounter;

    private void Start()
    {
        lifeCounter = transform.GetComponent<LifeCount>();
        livesRemaining = transform.GetComponent<LifeCount>().livesRemaining;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Player")
        {
            livesRemaining = 0;
           


        }


    }
}
