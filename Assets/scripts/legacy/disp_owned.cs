using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class disp_owned : MonoBehaviour {
	public Text qOwned;
	public Text displ;
	// Use this for initialization
	// Update is called once per frame
	void Update () {
		displ.text = "x"+qOwned.GetComponent<disp_cost>().owned+"";
	}
}
