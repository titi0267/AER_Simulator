using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public Canvas StartMenu;

    public void HideMenu()
    {
        StartMenu.gameObject.SetActive(false);
    }
    public void Quit()
    {
        Application.Quit();
    }   
}
