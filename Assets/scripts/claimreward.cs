using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class claimreward : MonoBehaviour {
    public GameObject button;
    public AudioSource audios;

    public AudioClip acl;
    public void claim()
    {
        long reward = review_rewards.reward;

        globVar.drinks += reward;
        globVar.totalDrinks += reward;
        Debug.Log("Rew = " + reward);

        globVar.rewCurr = false;//another can now spawn
        audios.GetComponent<AudioSource>().PlayOneShot(acl);
        button.SetActive(false);
    }
}
