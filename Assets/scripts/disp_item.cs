using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class disp_item : MonoBehaviour {
	public Text tLvl; // display the level (number owned)
	public Text tName;// item name
	public Text tEffect; //item effect description
	public Text tCost; //item cost

    public int index;// 0 -24

	public GameObject buyButton;//button to buy
	public Image locker;//lock conceal

	public String sName; //item name
	public String sEffect; //item description

	private bool locked = true;

	public long autoIncrAmount;
	public long manuIncrAmount;
	public long baseCost; //cost for first unit
	private long cost;//cost after mutliplier

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
    // Update is called once per frame
    void Update () {
		cost = (long)((baseCost*(Mathf.Pow(globVar.multiplier, globVar.qItem[index])))); //managing costs

		locker = locker.GetComponent<Image>();
		Color c = locker.color;

		tLvl.text = globVar.qItem[index]+""; //numowned are stored in an array.
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
        if (globVar.qItem[index] != 0)
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
		globVar.qItem[index] ++;
        Debug.Log("An item was bought. New qitem is " + globVar.qItem[index]);
	}


}
