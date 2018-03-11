using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class achievements : MonoBehaviour {
	public GameObject tBox;
	public GameObject tText;

	public void showAcv(string acv){
		Debug.Log ("ACHIEVEMENT:" + acv);
	}
	// Update is called once per frame
	void Update () {
		if (globVar.level >=1){ //strawberry
			globVar.acv [0] = true;
			showAcv ("STRAWBERRY");
		}
		/*if (cond){
			globVar.acv [1] = true;
		}if (cond){
			globVar.acv [2] = true;
		}if (cond){
			globVar.acv [3] = true;
		}if (cond){
			globVar.acv [4] = true;
		}if (cond){
			globVar.acv [5] = true;
		}if (cond){
			globVar.acv [6] = true;
		}if (cond){
			globVar.acv [7] = true;
		}if (cond){
			globVar.acv [8] = true;
		}if (cond){
			globVar.acv [9] = true;
		}if (cond){
			globVar.acv [10] = true;
		}if (cond){
			globVar.acv [11] = true;
		}if (cond){
			globVar.acv [12] = true;
		}if (cond){
			globVar.acv [13] = true;
		}if (cond){
			globVar.acv [14] = true;
		}
		*/
	}
}
