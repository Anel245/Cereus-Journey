using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    AudioSource audioSrc;
    BackgroundMusicManager Music;
    void Start()
    {
        //audioSrc = GetComponent<AudioSource>();
        //Music = GameObject.Find("BackgroundMusicManager").GetComponent<BackgroundMusicManager>();
       // Music.StopMusic();
       // audioSrc.Play();
        BackgroundMusicManager.Instance.PlaySound("GameOver");
        //BackgroundMusicManager.StopMusic();
        //BackgroundMusicManager.PlaySound("GameOver");
    }

    

}
