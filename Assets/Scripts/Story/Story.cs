using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Story : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("StoryDetection");
        if (collision.IsTouchingLayers(10, 11, 12, 13) == "Story_1")       
        {
            Debug.Log("Story_1");
            SoundManager.PlaySound("Triggerbox1");
            Destroy(collision.gameObject);
        }
        if (collision.IsTouchingLayers = "Story_2")
        {
            Debug.Log("Story_1");
            SoundManager.PlaySound("Triggerbox2");
            Destroy(collision.gameObject);
        }
        if (collision.IsTouchingLayers = "Story_3")
        {
            Debug.Log("Story_1");
            SoundManager.PlaySound("Triggerbox3");
            Destroy(collision.gameObject);
        }
        if (collision.IsTouchingLayers = "Story_4")
        {
            Debug.Log("Story_1");
            SoundManager.PlaySound("Triggerbox4");
            Destroy(collision.gameObject);
        }

    }
}
