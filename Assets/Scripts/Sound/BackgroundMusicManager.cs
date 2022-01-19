using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusicManager : MonoBehaviour
{

    public static AudioClip B_Music_1Music;
    static AudioSource audioSrc;

    void Start()
    {
        B_Music_1Music = Resources.Load<AudioClip>("B_Music_1");

        audioSrc = GetComponent<AudioSource>();
    }



    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "B_Music_1":
                audioSrc.PlayOneShot(B_Music_1Music);
                break;
                //BackgroundMusicManager.PlaySound("B_Music_1");

        }
    }
}
