using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autoclick : MonoBehaviour {

	// Use this for initialization
	void Start () {
		InvokeRepeating("master_incr",0,0.1f);
	}
	// Update is called once per frame
	void master_incr () {
		globVar.drinks += globVar.incr_auto/10.0;
		globVar.totalDrinks += globVar.incr_auto/10.0;
		//.money += (globVar.price*globVar.incr_auto/10.0);
	}
}
