using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip crossbowSound, enemyDiesSound, LifeLoosingSound;
    static AudioSource audioSrc;

    void Start()
    {
        crossbowSound = Resources.Load<AudioClip>("crossbow");
        enemyDiesSound = Resources.Load<AudioClip>("enemyDies");
        LifeLoosingSound = Resources.Load<AudioClip>("LifeLoosing");

        audioSrc = GetComponent<AudioSource>();
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

        }
    }
}
