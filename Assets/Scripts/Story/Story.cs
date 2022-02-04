using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Story : MonoBehaviour
{
    AudioSource audioSrc;
    public static AudioClip Triggerbox1Sound, Triggerbox2Sound, Triggerbox3Sound, Triggerbox4Sound;


    // Start is called before the first frame update
    void Start()
    {
        audioSrc = GameObject.Find("Story").GetComponent<AudioSource>();
        Triggerbox1Sound = Resources.Load<AudioClip>("Triggerbox1");
        Triggerbox2Sound = Resources.Load<AudioClip>("Triggerbox2");
        Triggerbox3Sound = Resources.Load<AudioClip>("Triggerbox3");
        Triggerbox4Sound = Resources.Load<AudioClip>("Triggerbox4");
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
            ChangeClip(Triggerbox1Sound);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.layer == 11)
        {
            Debug.Log("Story_2");
            SoundManager.PlaySound("Triggerbox2");
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.layer == 12)
        {
            Debug.Log("Story_3");
            SoundManager.PlaySound("Triggerbox3");
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.layer == 13)
        {
            Debug.Log("Story_4");
            SoundManager.PlaySound("Triggerbox4");
            Destroy(collision.gameObject);
        }


    }
    public void PauseMusic()
    {
        if (audioSrc.isPlaying)
        {
        audioSrc.Pause();
        }
    }
    public void UnPauseMusic()
    {
        if (!audioSrc.isPlaying)
        {
            audioSrc.UnPause();
        }
    }

    void ChangeClip(AudioClip newAudio)
    {
        audioSrc.clip = newAudio;
        audioSrc.Play();
    }

}
