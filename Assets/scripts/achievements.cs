using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class achievements : MonoBehaviour {
	public Image bg; // background image
	public GameObject b0; 
	public GameObject b1; 
	public GameObject b2; 
	public GameObject b3; 
	//public Image achBox;//achievement box
	public GameObject achBox;
	public Text tbox; // achievement text

	public AudioClip acvSound;
	public AudioSource audioSource;

	public IEnumerator showAcv(string acv){
		achBox.SetActive (true);
		globVar.numAcv++;
		audioSource.GetComponent<AudioSource> ().PlayOneShot (acvSound,0.5f);
		//Debug.Log ("ACHIEVEMENT UNLOCKED!\n" + acv);
		tbox.text = "ACHIEVEMENT UNLOCKED!\n" + acv;
		yield return new WaitForSeconds(3);
		achBox.SetActive (false);
	}
	// Update is called once per frame
	void Update () {
		//set each achievement once!
		if (globVar.drinks >= 10 && globVar.acv [0] == false) { //strawberry
			globVar.acv [0] = true;
			StartCoroutine(showAcv ("STRAWBERRY"));
		}
		if (globVar.level >= 1 && globVar.acv [1] == false) { //lychee
			globVar.acv [1] = true;
			StartCoroutine(showAcv ("LYCHEE"));
		}

		if (globVar.level >= 5 && globVar.acv [2] == false) { //honeydew
			globVar.acv [2] = true;
			StartCoroutine(showAcv ("HONEYDEW"));
		}
		if (globVar.totalDrinks >= 1000 && globVar.acv [3] == false) { //mango
			globVar.acv [3] = true;
			StartCoroutine(showAcv ("MANGO"));
		}

		//button seting

		if (globVar.acv[0] == true){
			b0.GetComponent<Button> ().interactable = true;
		} else {
			b0.GetComponent<Button> ().interactable = false;
		}
		if (globVar.acv[1] == true){
			b1.GetComponent<Button> ().interactable = true;
		} else {
			b1.GetComponent<Button> ().interactable = false;
		}
		if (globVar.acv[2] == true){
			b2.GetComponent<Button> ().interactable = true;
		} else {
			b2.GetComponent<Button> ().interactable = false;
		}
		if (globVar.acv[3] == true){
			b3.GetComponent<Button> ().interactable = true;
		} else {
			b3.GetComponent<Button> ().interactable = false;
		}
	}
}
