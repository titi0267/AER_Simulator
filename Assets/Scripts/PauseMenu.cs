using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public static bool InSettings = false;
    public GameObject pauseMenuUI;
    public GameObject SettingsMenu;
    public AudioSource audioPlayer;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (GameIsPaused && !InSettings) {
                Resume();
            } else if (!GameIsPaused && !InSettings) {
                Pause();
            } else {
                ReturnToprevious();
            }
        }
    }

    public void Resume()
    {
        audioPlayer.UnPause();
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        audioPlayer.Pause();
        pauseMenuUI.SetActive(true);
        if (InSettings) {
            InSettings = false;
        }
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void ReturnToMenu()
    {
        pauseMenuUI.gameObject.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene("SampleScene2");

    }

    public void GoToSettings()
    {
        SettingsMenu.gameObject.SetActive(true);
        InSettings = true; 
    }

    public void ReturnToprevious()
    {
        SettingsMenu.gameObject.SetActive(false);
        InSettings = false; 
    }
}
