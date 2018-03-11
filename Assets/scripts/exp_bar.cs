using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class exp_bar : MonoBehaviour {
	public Image bar;
	private long expNext = 100; //next level req
	private long expPrev = 0; //sum of previous experience, temporary
	private float percExp;
	// Use this for initialization
	void Start () {
		Image bar = GetComponent<Image>();
	}

	// Update is called once per frame
	void Update () {
		globVar.exp = (long)globVar.totalDrinks;
		percExp = (globVar.exp - expPrev)/(expNext*1.0f);
		//Debug.Log ("exp "+globVar.exp+" perc "+percExp);
		bar.fillAmount = percExp;
		if (percExp >=1){
			levelUp();
		}
	}
	void levelUp(){
		expPrev = globVar.exp;
		expNext *=(long) Mathf.Pow(globVar.lvlMulti,(float)globVar.level);
		globVar.level ++;
	}
}
