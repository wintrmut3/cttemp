using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upgrade : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	public int upgrade_value;
	public int base_cost;
	public void autoIncr(){
		int cost = base_cost+(upgrade_value*2);
		globVar.incr_auto += upgrade_value;
		globVar.drinks -= cost;
	}
}
