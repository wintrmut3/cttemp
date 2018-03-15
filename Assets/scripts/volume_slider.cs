using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class volume_slider : MonoBehaviour {
    void Start()
    {
        
    }
    // Update is called once per frame
    public void ChangeAudio (float vol) {
        AudioListener.volume = vol;
	}
}
