using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class disp_dtds : MonoBehaviour {
	public Text box;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		box.text = ""+((long)globVar.incr_auto).ToString("n0")+"/s";

	}
}
