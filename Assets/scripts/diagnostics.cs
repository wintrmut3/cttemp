using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diagnostics : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		Debug.Log("UPG Counter: "+globVar.upg_counter);
		Debug.Log("FLV Counter: "+globVar.flv_counter);
		/*Debug.Log("UPG Counter: "+globVar.upg_counter);
		Debug.Log("UPG Counter: "+globVar.upg_counter);
		Debug.Log("UPG Counter: "+globVar.upg_counter);
*/
	}
}
