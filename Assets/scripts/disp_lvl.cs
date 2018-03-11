using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class disp_lvl : MonoBehaviour {
	public Text textbox;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		textbox.text = globVar.level+"";
	}
}
