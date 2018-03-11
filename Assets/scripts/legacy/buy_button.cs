using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class buy_button : MonoBehaviour {
	public GameObject othgo;
	public GameObject button;
	private long cost = 0;
	public long incr_amount;//amount to increment autoclick by
	public long incr_click;//amount to increment bbt/click by
	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	public void Clicked () {
		cost  = (long) othgo.GetComponent<disp_cost>().finalCost;
		globVar.money -= cost;
		othgo.GetComponent<disp_cost>().owned +=1;
		globVar.incr_auto += incr_amount;
		globVar.incr_click += incr_click;
	}
	void Update(){
		cost  = (long) othgo.GetComponent<disp_cost>().finalCost;
		Debug.Log("cost"+othgo.GetComponent<disp_cost>().finalCost);
		if  (cost > globVar.money){
			button.GetComponent<Button>().interactable = false;
		}
		else{
			button.GetComponent<Button>().interactable = true;
		}
	}
}
