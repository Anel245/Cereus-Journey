using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    AudioSource audioSrc;
    BackgroundMusicManager Music;
    SoundManager Sound;

    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
        Music = GameObject.Find("BackgroundMusicManager").GetComponent<BackgroundMusicManager>();
        Sound = GameObject.Find("SoundManager").GetComponent<SoundManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                BackgroundMusicManager.Instance.PlaySound("B_Music_1");
                Resume();
                //audioSrc.Play();
                //Debug.Log("playsound");
                //BackgroundMusicManager.Instance.PlaySound("B_Music_1");

            }
            else
            {
                Pause();
                Music.StopMusic();
                Sound.StopMusic();

            }
        }
    }
     public void Resume ()
    {
        BackgroundMusicManager.Instance.PlaySound("B_Music_1");
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void GoToMainMenu()
    {
        //TODO place Main Menu music
        BackgroundMusicManager.Instance.PlaySound("MainMenu");
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
}
