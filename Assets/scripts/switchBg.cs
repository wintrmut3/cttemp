using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class switchBg : MonoBehaviour {
	public Sprite bgi;
	public Image bg;

	// Use this for initialization
	public void switchBG (){
		bg.GetComponent<Image> ().sprite = bgi;	
	}
}
