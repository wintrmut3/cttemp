using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class autoRun : MonoBehaviour {
    void Awake() //UNCOMMENT WHEN RELEASING!
    {
        saver.Load();
        //Debug.Log("Loaded!");
    }
    void OnDestroy()
    { 
        saver.Save();
    }
    public void OnApplicationQuit()
    {
        saver.Save();
        //Debug.Log("Saved!");
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            PlayerPrefs.DeleteAll();
            Debug.Log("deleted");
        }
    }

    /*
    public void cheeseSave()
    {
        saver.Save();
    }

    public void cheeseLoad()
    {
        saver.Load();
    }
    private void Update()
    {
        //Debug.Log(globVar.exp);
    }
    */


}
