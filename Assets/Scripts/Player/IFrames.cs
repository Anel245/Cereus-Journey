using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IFrames : MonoBehaviour
{
    [Header("IFrame")]
    public Color flashColor;
    public Color regularColor;
    public float flashDuration;
    public int numberOfFlashes;
    public Collider2D triggerCollider;
    public SpriteRenderer mySprite;
    public float Time = 3f;
    [HideInInspector]
    public bool CanTakeDamage = true;

   

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Enemy")
        {
            if (CanTakeDamage)
            {
                Debug.Log(CanTakeDamage + "AHHHHHH");
                if (isActiveAndEnabled)
                    StartCoroutine(FlashCo());
            }
        }
    }

    private IEnumerator FlashCo()
    {
        float timer = 0f;
        Debug.Log("OHHHHHH");
        int temp = 0;
        //triggerCollider.enabled = false;
        CanTakeDamage = false;
        Physics2D.IgnoreLayerCollision(6, 7, false);
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
        Physics2D.IgnoreLayerCollision(6, 7, true);
        //triggerCollider.enabled = true;
    }
}
