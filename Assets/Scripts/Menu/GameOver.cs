using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    AudioSource audioSrc;
    BackgroundMusicManager Music;
    SoundManager soundManager;
    void Start()
    {
        //audioSrc = GetComponent<AudioSource>();
        //Music = GameObject.Find("BackgroundMusicManager").GetComponent<BackgroundMusicManager>();
        // Music.StopMusic();
        // audioSrc.Play();
        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>();
        soundManager.StopMusic();
        BackgroundMusicManager.Instance.PlaySound("GameOver");
        //BackgroundMusicManager.StopMusic();
        //BackgroundMusicManager.PlaySound("GameOver");
    }

    

}
