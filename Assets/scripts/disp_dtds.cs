using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class disp_dtds : MonoBehaviour {
	public Text box;
    private double dps;
    // Use this for initialization

    IEnumerator Waiting ()
    {
        double first = globVar.totalDrinks;
        yield return new WaitForSeconds(1);
        double next = globVar.totalDrinks;
        dps = (next - first);
       // Debug.Log(dps);
    }


	// Update is called once per frame
	void Update () {
        StartCoroutine(Waiting());
        box.text = "" + ((long)globVar.incr_auto).ToString("n0") + "/s";
        box.text = ""+((long)dps).ToString("n0")+"/s";

	}
}
