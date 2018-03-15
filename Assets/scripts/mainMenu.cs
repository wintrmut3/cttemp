using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour {
    public GameObject helpMenu;
    public void StartGame()
    {
        SceneManager.LoadSceneAsync("main_re", LoadSceneMode.Single);
    }
    public void Help()
    {
        if (helpMenu.activeSelf == true)
        {
            helpMenu.SetActive(false);
        }
        else
        {
            helpMenu.SetActive(true);
        }
    }
}
