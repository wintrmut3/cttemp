using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class quit : MonoBehaviour {

    public void quitB() {
        Application.Quit();
    }
    public void quitMenu()
    {
        SceneManager.LoadSceneAsync("menu",LoadSceneMode.Single);
    }

}
