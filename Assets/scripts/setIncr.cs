using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setIncr : MonoBehaviour {
    public GameObject[] items = new GameObject[25];
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        long totalIncrAuto = 0;
        long totalIncrClick = 0;
        int quantity = 0;
        long indivIA = 0;
        long indivIC = 0;
        for (int i = 0; i < 25; i++)
        {
            quantity = items[i].GetComponent<disp_item>().qLvl;

            indivIA = items[i].GetComponent<disp_item>().autoIncrAmount;

            indivIC = items[i].GetComponent<disp_item>().manuIncrAmount;


            totalIncrAuto += quantity * indivIA;
            totalIncrClick += quantity * indivIC;

        }
        globVar.incr_auto = totalIncrAuto;
        globVar.incr_click = totalIncrClick;
    }
}
