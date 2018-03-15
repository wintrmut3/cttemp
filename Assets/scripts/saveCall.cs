using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saveCall : MonoBehaviour {
    public void OnApplicationQuit()
    {
        saver.Save();
    }

}
