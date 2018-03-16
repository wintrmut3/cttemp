using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class preserveCanvas : MonoBehaviour {

    // Use this for initialization
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

}
