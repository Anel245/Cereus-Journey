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
        if (collision.gameObject.layer == 10)       
        {
            Debug.Log("Story_1");
            SoundManager.PlaySound("Triggerbox1");
            Destroy(collision.gameObject);
        }


    }
}
