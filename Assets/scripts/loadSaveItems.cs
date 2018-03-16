using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadSaveItems : MonoBehaviour {
    public static bool firstView = false;
    public static int TimesOpened = 0;

    public void SaveItems()
    {
        string[] itemNumsStringArray = new string[25];
        for (int i = 0; i < 25; i++)
        {
            itemNumsStringArray[i] = globVar.qItem[i].ToString();
        }
        PlayerPrefs.SetString("itemNumString", string.Join(",", itemNumsStringArray));

        PlayerPrefs.Save();
        Debug.Log("saved");
        Debug.Log(string.Join(",", itemNumsStringArray));

    }
    public void LoadItems()
    {
        string[] itemNumsStringArr = PlayerPrefs.GetString("itemNumString", "0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0").Split(',');

        for (int i = 0; i < 25; i++)
        {
            globVar.qItem[i] = System.Int32.Parse(itemNumsStringArr[i]);//(int)Random.Range(3, 10);
        }
    }

    private void Update()
    {
        for (int i = 0; i < 3; i++)
        {
            Debug.Log(i+ " : " + globVar.qItem[i]);
        }
    }
    private void Start()
    {
        LoadItems();
    }
    private void OnEnable()
    {
        LoadItems();
    }
    private void OnDisable()
    {
        SaveItems();
    }


}
