using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public Canvas StartMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void HideMenu()
    {
        StartMenu.gameObject.SetActive(false);
    }
    public void Quit()
    {
        print("ça quitte pas");
        Application.Quit();
    }
}
