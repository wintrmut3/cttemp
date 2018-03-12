using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class progressBar : MonoBehaviour {
    public Image bar;
	public Text txtbox;

    // Use this for initialization
    void Start () {
        Image bar = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update () {
        bar.fillAmount = globVar.numAcv/16.0f;//total number of achievements
		txtbox.text = globVar.numAcv + " / 16";
    }
}
