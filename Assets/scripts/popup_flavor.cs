using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popup_flavor : MonoBehaviour {
	public GameObject panel;

	public void showF(){
		if (globVar.upg_counter % 2 != 1) {
			globVar.flv_counter++;
		}

		if (globVar.flv_counter%2==1){
			panel.gameObject.SetActive (true);
		}

		else{
			panel.gameObject.SetActive(false);
		}
	}

	void Update(){

	}
}
