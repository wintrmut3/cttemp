using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class disp_cost : MonoBehaviour {
	public long baseCost = 0;
	public Text textBox;
	public int owned  =0;
	public long finalCost =0;
	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		finalCost =(long)((baseCost*(Mathf.Pow(globVar.multiplier,owned))));
		textBox.text = finalCost.ToString("n0")+"";
	}
}
