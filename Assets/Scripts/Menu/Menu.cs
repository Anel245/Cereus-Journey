using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
   
    public void PlayGame(){

        SceneManager.LoadScene("Level01");
        SoundManager.PlaySound("B_Music_1");

        Debug.Log("Button is pressed");
    }


} 
