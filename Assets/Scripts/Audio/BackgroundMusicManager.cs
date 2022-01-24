using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusicManager : MonoBehaviour
{
    
    public AudioClip B_Music_1Music, MainMenuMusic, GameOverMusic;
    static AudioSource audioSrc;

    #region Singleton
    static BackgroundMusicManager instance;
    public static BackgroundMusicManager Instance
    {
        get
        {
            if (!instance)
            {
                Debug.LogError("[BackgroundMusicManager]: I'm the instance");
            }

            return instance;
        }
    }
    private void Awake()
    {
        if (instance && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(this.gameObject);
    }
    #endregion

    void Start()
    {
        B_Music_1Music = Resources.Load<AudioClip>("B_Music_1");
        MainMenuMusic = Resources.Load<AudioClip>("MainMenu");
        //GameOverMusic = Resources.Load<AudioClip>("GameOver");

        audioSrc = GetComponent<AudioSource>();
    }

    public  void StopMusic()
    {
        audioSrc.Stop();
    }



    public void PlaySound(string clip)
    {
        switch (clip)
        {
            case "B_Music_1":
                ChangeClip(B_Music_1Music);

               //audioSrc.PlayOneShot(B_Music_1Music);
                break;
             //BackgroundMusicManager.PlaySound("B_Music_1");
            case "MainMenu":
                ChangeClip(MainMenuMusic);
                
                break;
            //BackgroundMusicManager.PlaySound("MainMenu");
            case "GameOver":
                ChangeClip(GameOverMusic);
               
                break;
                //BackgroundMusicManager.PlaySound("GameOver");

        }
    }

    private void ChangeClip(AudioClip newClip)
    {
        audioSrc.Stop();
        audioSrc.clip = newClip;
        audioSrc.Play();
    }
}
