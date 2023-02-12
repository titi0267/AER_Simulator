using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Canvas StartMenu;
    public string sceneName;

    public void HideMenu()
    {
        StartMenu.gameObject.SetActive(false);
        SceneManager.LoadScene(sceneName);

    }
    public void Quit()
    {
        Application.Quit();
    }   
}
