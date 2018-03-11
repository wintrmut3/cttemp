using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class globVar : MonoBehaviour {
	public static double drinks = 0;
	public static double money = 1000;
	public static long incr_click = 1; //default click
	public static long incr_auto = 0; //autoclick
	public static long upg_counter = 0;//initstate
	public static long flv_counter = 0;//initstate

	public static bool openWindow = false; // is there another window open?

	public static long price = 1; //price per drink
	public static float multiplier = 1.09f;//cost multiplier
	public static float lvlMulti = 1.1f;

	public static long exp = 0; // experience
	public static int level = 0;

}
