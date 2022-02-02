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


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Enemy")
        {

            Debug.Log("AHHHHHH");
            StartCoroutine("FlashCo()");

        }
    }

    private IEnumerator FlashCo()
    {
        int temp = 0;
        //triggerCollider.enabled = false;
        Physics2D.IgnoreLayerCollision(6, 7, false);
        while (temp < numberOfFlashes)
        {
            mySprite.color = flashColor;
            yield return new WaitForSeconds(flashDuration);
            mySprite.color = regularColor;
            yield return new WaitForSeconds(flashDuration);
            temp++;
        }
        Physics2D.IgnoreLayerCollision(6, 7, true);
        //triggerCollider.enabled = true;
    }
}
