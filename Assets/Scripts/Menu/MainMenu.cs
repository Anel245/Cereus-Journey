using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        BackgroundMusicManager.Instance.PlaySound("B_Music_1");
        Debug.Log("Play");
        SceneManager.LoadScene("Level01");
    }
    public void GoToSettingsMenu()
    {
        SceneManager.LoadScene("SettingsMenu");
    }
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void GoToControlsMenu()
    {
        SceneManager.LoadScene("ControlsMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
