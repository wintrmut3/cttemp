using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saver : MonoBehaviour {


    public static void Save()
    {


        string[] acvStr = new string[globVar.acv.Length];


        //converting achievements from bool array to string array
        for (int i = 0; i < globVar.acv.Length; i++)
        {
            acvStr[i] = globVar.acv[i].ToString();
            //Debug.Log(acvStr[i]);
        }
        //SAVING GLOBAL VARIABLES
        PlayerPrefs.SetString("drinks", globVar.drinks.ToString());
        PlayerPrefs.SetString("total drinks", globVar.totalDrinks.ToString());
        PlayerPrefs.SetString("total clicks", globVar.totalClicks.ToString());
        PlayerPrefs.SetString("dps", globVar.incr_auto.ToString());
        PlayerPrefs.SetString("dpt", globVar.incr_click.ToString());
        PlayerPrefs.SetInt("numAcv", globVar.numAcv);
        PlayerPrefs.SetInt("upgCounter", globVar.upg_counter);
        PlayerPrefs.SetInt("flvCounter", globVar.flv_counter);
        PlayerPrefs.SetInt("stgCounter", globVar.stg_counter);
        PlayerPrefs.SetString("EXP", globVar.exp.ToString());
        PlayerPrefs.SetInt("Level", globVar.level);

        PlayerPrefs.SetString("BooleanAchievements", string.Join(",", acvStr, 0, 16));
        //Debug.Log(PlayerPrefs.GetString("BooleanAchievements", "0").ToString());
       
        //SAVING NUMBER OF ITEMS


        PlayerPrefs.Save();
       
    }

    public static void Load()
    {
        //loading achievement array
        /*for (int i = 0; i < globVar.acv.Length; i++)
        {
            acvStr[i] = globVar.acv[i].ToString();
            Debug.Log(acvStr[i]);
        }
        */
        string[] acvStringArr = PlayerPrefs.GetString("BooleanAchievements", "0").Split(',');
        bool[] acvSaved = new bool[globVar.acv.Length];
        for (int i = 0; i < globVar.acv.Length; i++)
        {
            acvSaved[i] = System.Convert.ToBoolean(acvStringArr[i]);
           // Debug.Log(acvSaved[i].ToString());
           // Debug.Log("savedathing");

        }
       /* for (int i = 0; i < 25; i++)
        {
            items[i].GetComponent<disp_item>().qLvl = System.Convert.ToInt32(itemNumsStringArr[i]);
        }
        */


        globVar.drinks = double.Parse(PlayerPrefs.GetString("drinks", "0"));
        globVar.totalDrinks = double.Parse(PlayerPrefs.GetString("total drinks", "0"));
        globVar.totalClicks = long.Parse(PlayerPrefs.GetString("total clicks", "0"));
        globVar.incr_auto = long.Parse(PlayerPrefs.GetString("dps", "0"));
        globVar.incr_click = long.Parse(PlayerPrefs.GetString("dpt", "0"));
        globVar.numAcv = PlayerPrefs.GetInt("numAcv", 0);
        globVar.upg_counter =  PlayerPrefs.GetInt("upgCounter", 0);
        globVar.flv_counter = PlayerPrefs.GetInt("flvCounter", 0);
        globVar.stg_counter = PlayerPrefs.GetInt("stgCounter", 0);
        globVar.exp = long.Parse(PlayerPrefs.GetString("EXP", "0"));
        globVar.level = PlayerPrefs.GetInt("Level", 0);
        globVar.acv = acvSaved;
        //Debug.Log(acvSaved.ToString());

        
    }
}
