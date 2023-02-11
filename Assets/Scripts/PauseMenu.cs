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
    public GameObject StartMenu;
    public GameObject SettingsMenu;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (GameIsPaused && !InSettings && !StartMenu.gameObject.activeSelf) {
                Resume();
            } else if (!GameIsPaused && !InSettings && !StartMenu.gameObject.activeSelf) {
                Pause();
            } else {
                ReturnToprevious();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        if (InSettings) {
            InSettings = false;
        }
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void ReturnToMenu()
    {
        StartMenu.gameObject.SetActive(true);
        pauseMenuUI.gameObject.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

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
