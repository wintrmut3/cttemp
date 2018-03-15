using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour {
    public GameObject helpMenu;
    int help_counter = 0;
    public void StartGame()
    {
        SceneManager.LoadSceneAsync("main_re", LoadSceneMode.Single);
    }
    public void Help()
    {
        help_counter++;        
    }
}
