using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage_Death : MonoBehaviour
{

    public int enemyHP = 100;

    public Color flashColor;
    public Color regularColor;
    public float flashDuration;
    public int numberOfFlashes;
    public SpriteRenderer mySprite;
    public float Time = 3f;
    [HideInInspector]
    public bool CanTakeDamage = true;

    public void TakeDamage(int damageAmount)
    {
        enemyHP -= damageAmount;
        if (enemyHP > 0)
        {            
            print("I'm in pain");
        }
        else
        {          
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

    private IEnumerator Flash()
    {
        float timer = 0f;
        Debug.Log("UGHHHHHH");
        int temp = 0;       
        CanTakeDamage = false;       
        while (timer < Time)
        {
            mySprite.color = flashColor;
            yield return new WaitForSeconds(flashDuration);
            timer = timer + flashDuration;
            mySprite.color = regularColor;
            yield return new WaitForSeconds(flashDuration);
            timer = timer + flashDuration;

        }
        CanTakeDamage = true;             
    }

}
