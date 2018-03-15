﻿using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class disp_item : MonoBehaviour {
	public Text tLvl; // display the level (number owned)
	public Text tName;// item name
	public Text tEffect; //item effect description
	public Text tCost; //item cost

	public GameObject buyButton;//button to buy
	public Image locker;//lock conceal

	public String sName; //item name
	public String sEffect; //item description

	private bool locked = true;

	public long autoIncrAmount;
	public long manuIncrAmount;
	public int qLvl; // the amount owned
	public long baseCost; //cost for first unit
	private long cost;//cost after mutliplier

	// Update is called once per frame
	void Update () {
		cost = (long)((baseCost*(Mathf.Pow(globVar.multiplier,qLvl)))); //managing costs

		locker = locker.GetComponent<Image>();
		Color c = locker.color;

		tLvl.text = qLvl+"";
		tName.text = sName;
		tEffect.text  = sEffect;
		tCost.text = ""+ (cost).ToString("n0");

		//alpha = locker.GetComponent<Image>().color.a;
		if  (cost > globVar.drinks){ //to disable the button if inadequate funds
			buyButton.GetComponent<Button>().interactable = false;		//toggle locked only ONCE
		}
        else
        {
            buyButton.GetComponent<Button>().interactable = true;
            locked = false;
        }
        if (qLvl != 0)
        {
            locked = false;
        }
		
		//lock color setting
		if (locked){
			c.a = 1;
		}
		else{
			c.a = 0;
		}
		locker.color = c;
	}
	public void Buy(){ //activatebybutton
		globVar.drinks -= cost;
		qLvl +=1;
	}
}
