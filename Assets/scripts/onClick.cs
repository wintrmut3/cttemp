using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onClick : MonoBehaviour {
	public void increment (){
		globVar.drinks +=globVar.incr_click;
		globVar.totalDrinks += globVar.incr_click;
		//globVar.money +=globVar.price*globVar.incr_click;
	}
}
