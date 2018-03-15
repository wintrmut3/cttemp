using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class review_rewards : MonoBehaviour {

    public GameObject revBox; //box for reviews
    private int nextActionTime = 10;
    public int period = 1; //seconds after to execute
    public static int numStars = 4;
    public static long reward;

    public Sprite fostar;
    public Sprite fistar;
    

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        int t = (int)Time.time; // time in seconds afte rstart of game
        if (t > nextActionTime && globVar.drinks >1) 
        {
            if (globVar.rewCurr == false)
            {
                if (numStars == 4)
                {
                    revBox.GetComponent<Image>().sprite = fostar;
                    reward = globVar.incr_auto * (long)Random.Range(2.5f, 4f) + 10;

                }
                else if (numStars == 5)
                {
                    revBox.GetComponent<Image>().sprite = fistar;
                    reward = globVar.incr_auto * (long)Random.Range(35f, 50f) + 100;

                }

                globVar.rewCurr = true;//another will not spawn for now

                revBox.SetActive(true);//make the button active
                numStars = (int)Random.Range(3f, 5f) + 1; //regen random review
               // Debug.Log("NS:" + numStars);
            }

            period = (int)Random.Range(30f, 75f);
            //period = 0;
            nextActionTime += period; //make this random next time


        }
    }
}
