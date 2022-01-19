using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusicManager : MonoBehaviour
{

    public static AudioClip B_Music_1Music, MainMenuMusic, GameOverMusic;
    static AudioSource audioSrc;

    void Start()
    {
        B_Music_1Music = Resources.Load<AudioClip>("B_Music_1");
        MainMenuMusic = Resources.Load<AudioClip>("MainMenu");
        GameOverMusic = Resources.Load<AudioClip>("GameOver");

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
            case "MainMenu":
                audioSrc.PlayOneShot(MainMenuMusic);
                break;
            //BackgroundMusicManager.PlaySound("MainMenu");
            case "GameOver":
                audioSrc.PlayOneShot(GameOverMusic);
                break;
                //BackgroundMusicManager.PlaySound("GameOver");
        }
    }
}
