using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popup_menu : MonoBehaviour {
	public GameObject z;//the panel

	public void show(){
		if (globVar.flv_counter % 2 != 1) {
			globVar.upg_counter++;
		}

		if (globVar.upg_counter%2==1){
			z.gameObject.SetActive (true);
		}

		else{
			z.gameObject.SetActive(false);
		}
	}

	void Update(){


	}
}
