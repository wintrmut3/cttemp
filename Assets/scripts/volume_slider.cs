using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class volume_slider : MonoBehaviour {
    void Start()
    {
        
    }
    // Update is called once per frame
    public void ChangeAudio () {
        if (AudioListener.volume == 1)
        {
            AudioListener.volume = 0;
        }
        else
        {
            AudioListener.volume = 1;
        }
    }
}
