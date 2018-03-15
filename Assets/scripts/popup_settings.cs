using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popup_settings : MonoBehaviour {
    public GameObject panel;

    public void showStg()
    {
        /*if (globVar.stg_counter % 2 != 1)
        {
            globVar.stg_counter++;
        }
        */
        globVar.stg_counter++;

        if (globVar.stg_counter % 2 == 1)
        {
            panel.gameObject.SetActive(true);
        }

        else
        {
            panel.gameObject.SetActive(false);
        }
        Debug.Log(globVar.stg_counter);
    }
}
