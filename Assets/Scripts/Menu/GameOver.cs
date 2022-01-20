using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    AudioSource audioSrc;
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
        BackgroundMusicManager.PlaySound("GameOver");
    }

    

}
