using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage_Death : MonoBehaviour
{

    public int enemyHP = 100;
    

    public void TakeDamage(int damageAmount)
    {
        enemyHP -= damageAmount;
        if (enemyHP > 0)
        {
            //Maybe if there is a Hit animation, play it here
            print("I'm in pain");

        }
        else
        {
            //Maybe if there is a Death animation, play it here
            print("I died lol");
            SoundManager.PlaySound("EnemyDeath");
            GetComponent<CapsuleCollider2D>().enabled = false;
            this.enabled = false;
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("test");
        if (collision.tag == "Bullet")
        {
            Debug.Log("collision");
            TakeDamage(25);
            //TODO place sound here !
            SoundManager.PlaySound("enemyDies");
            Destroy(collision.gameObject);
            
        }
        
    }

}
