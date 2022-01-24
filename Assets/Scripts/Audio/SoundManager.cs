using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip crossbowSound, enemyDiesSound, LifeLoosingSound, JumpSound, EnemyDeathSound, PlayerDeathSound, LandingSound;
    static AudioSource audioSrc;

    void Start()
    {
        crossbowSound = Resources.Load<AudioClip>("crossbow");
        enemyDiesSound = Resources.Load<AudioClip>("enemyDies");
        LifeLoosingSound = Resources.Load<AudioClip>("LifeLoosing");
        JumpSound = Resources.Load<AudioClip>("Jump");
        EnemyDeathSound = Resources.Load<AudioClip>("EnemyDeath");
        PlayerDeathSound = Resources.Load<AudioClip>("PlayerDeath");
        LandingSound= Resources.Load<AudioClip>("Landing");
        //  = Resources.Load<AudioClip>("");

        audioSrc = GetComponent<AudioSource>();
    }
    public void StopMusic()
    {
        audioSrc.Stop();
    }



    public static void PlaySound (string clip)
    {
        switch (clip)
        { 
        case "crossbow":
                audioSrc.PlayOneShot (crossbowSound);
                break;
        case "enemyDies":
                audioSrc.PlayOneShot(enemyDiesSound);
                break;
        case "LifeLoosing":
                audioSrc.PlayOneShot(LifeLoosingSound);
                break;
        case "Jump":
                audioSrc.PlayOneShot(JumpSound);
                break;
        case "EnemyDeath":
                audioSrc.PlayOneShot(EnemyDeathSound);
                break;
        case "PlayerDeath":
                audioSrc.PlayOneShot(PlayerDeathSound);
                break;
        case "Landing":
                audioSrc.PlayOneShot(LandingSound);
                break;

                //SoundManager.PlaySound("Landing");

        }
    }
}
