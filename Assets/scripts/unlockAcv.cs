using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unlockAcv : MonoBehaviour {
	public GameObject[] screens;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		for (int i = 0; i < globVar.acv.Length;i++){
			if (screens [i] != null) { // a temporary measure before all 16 are implemented
				if (globVar.acv [i] == true) {
					screens [i].SetActive (false);
				} else {
					screens [i].SetActive (true);
				}
			}

		}	
	}
}
