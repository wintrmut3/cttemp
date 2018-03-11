using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class disp_Dt : MonoBehaviour {
	public Text box;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		long drinks = (long)globVar.drinks;
		box.text = ""+/*Mathf.RoundToInt((float)globVar.drinks)*/(drinks).ToString("n0");

	}
}
