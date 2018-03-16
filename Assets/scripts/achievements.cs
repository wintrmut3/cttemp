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
    public GameObject b4;
    public GameObject b5;
    public GameObject b6;
    public GameObject b7;
    public GameObject b8;
    public GameObject b9;
    public GameObject b10;
    public GameObject b11;
    public GameObject b12;
    public GameObject b13;
    public GameObject b14;
    public GameObject b15;

    public GameObject impulsepressContainer;
    public GameObject spaceJellyContainer;
    public GameObject ftlPressContainer;

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
        int numSJ = globVar.qItem[14];
        int numImp = globVar.qItem[13];
        int numFTL = globVar.qItem[22];

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
        if (globVar.totalClicks >= 500 && globVar.acv[4] == false) // green apple
        {
            globVar.acv[4] = true;
            StartCoroutine(showAcv("GREEN APPLE"));
        }
        if (globVar.incr_auto >= 25 && globVar.acv[5] == false) // blueberry
        {
            globVar.acv[5] = true;

            StartCoroutine(showAcv("BLUEBERRY"));
        }
        if (globVar.incr_auto >=333 && globVar.acv[6] == false) //durian
        {
            globVar.acv[6] = true;

            StartCoroutine(showAcv("DURIAN"));
        }
        if (globVar.level >= 20 && globVar.acv[7] == false) // lemonHoney
        {
            globVar.acv[7] = true;

            StartCoroutine(showAcv("HONEY LEMON"));
        }
        if (globVar.totalDrinks >= 1000000 && globVar.acv[8] == false) // papaya
        {
            globVar.acv[8] = true;

            StartCoroutine(showAcv("PAPAYA"));
        }
        if (numSJ >=1 && globVar.acv[9] == false) // avocado
        {
            globVar.acv[9] = true;

            StartCoroutine(showAcv("AVOCADO"));
        }
        if (numImp >= 1 && globVar.acv[10] == false) // grape
        {
            globVar.acv[10] = true;

            StartCoroutine(showAcv("GRAPE"));
        }
        if (Time.time >= 3600 && globVar.acv[11] == false) // pineapple
        {
            globVar.acv[11] = true;
            StartCoroutine(showAcv("PINEAPPLE"));
        }
        if (globVar.drinks >= 1000000000 && globVar.acv[12] == false) // peach
        {
            globVar.acv[12] = true;

            StartCoroutine(showAcv("PEACH"));
        }
        if (globVar.totalDrinks >= 7500000000 && globVar.acv[13] == false) // watermelon
        {
            globVar.acv[13] = true;

            StartCoroutine(showAcv("WATERMELON"));
        }
        if (globVar.totalDrinks >= 18000000000000 && globVar.acv[14] == false) // taro
        {
            globVar.acv[14] = true;

            StartCoroutine(showAcv("TARO"));
        }
        if (numFTL >= 1 && globVar.acv[15] == false) // dragonFruit
        {
            globVar.acv[15] = true;

            StartCoroutine(showAcv("DRAGONFRUIT"));
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
        if (globVar.acv[4] == true)
        {
            b4.GetComponent<Button>().interactable = true;
        }
        else
        {
            b4.GetComponent<Button>().interactable = false;
        }
        if (globVar.acv[5] == true)
        {
            b5.GetComponent<Button>().interactable = true;
        }
        else
        {
            b5.GetComponent<Button>().interactable = false;
        }
        if (globVar.acv[6] == true)
        {
            b6.GetComponent<Button>().interactable = true;
        }
        else
        {
            b6.GetComponent<Button>().interactable = false;
        }
        if (globVar.acv[7] == true)
        {
            b7.GetComponent<Button>().interactable = true;
        }
        else
        {
            b7.GetComponent<Button>().interactable = false;
        }
        if (globVar.acv[8] == true)
        {
            b8.GetComponent<Button>().interactable = true;
        }
        else
        {
            b8.GetComponent<Button>().interactable = false;
        }
        if (globVar.acv[9] == true)
        {
            b9.GetComponent<Button>().interactable = true;
        }
        else
        {
            b9.GetComponent<Button>().interactable = false;
        }
        if (globVar.acv[10] == true)
        {
            b10.GetComponent<Button>().interactable = true;
        }
        else
        {
            b10.GetComponent<Button>().interactable = false;
        }
        if (globVar.acv[11] == true)
        {
            b11.GetComponent<Button>().interactable = true;
        }
        else
        {
            b11.GetComponent<Button>().interactable = false;
        }
        if (globVar.acv[12] == true)
        {
            b12.GetComponent<Button>().interactable = true;
        }
        else
        {
            b12.GetComponent<Button>().interactable = false;
        }
        if (globVar.acv[13] == true)
        {
            b13.GetComponent<Button>().interactable = true;
        }
        else
        {
            b13.GetComponent<Button>().interactable = false;
        }
        if (globVar.acv[14] == true)
        {
            b14.GetComponent<Button>().interactable = true;
        }
        else
        {
            b14.GetComponent<Button>().interactable = false;
        }
        if (globVar.acv[15] == true)
        {
            b15.GetComponent<Button>().interactable = true;
        }
        else
        {
            b15.GetComponent<Button>().interactable = false;
        }
    }
}
