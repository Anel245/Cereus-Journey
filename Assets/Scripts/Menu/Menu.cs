using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
   
    public void PlayGame(){

        SceneManager.LoadScene("Level01");

        Debug.Log("Button is pressed");
    }


} // class
