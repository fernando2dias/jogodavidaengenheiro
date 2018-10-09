using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MudaCamTxt : MonoBehaviour {

    public Text t1, t2, t3;
    public Camera c1, c2;

	// Use this for initialization
	void Start () {
        c1.gameObject.SetActive(true);
        c2.gameObject.SetActive(false);
        t1.gameObject.SetActive(false);
        t2.gameObject.SetActive(false);
        t3.gameObject.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.E))
        {
            c1.gameObject.SetActive(false);
            c2.gameObject.SetActive(true);
            t1.gameObject.SetActive(true);
            t3.gameObject.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            c1.gameObject.SetActive(true);
            c2.gameObject.SetActive(false);
            t1.gameObject.SetActive(false);
            t2.gameObject.SetActive(false);
            t3.gameObject.SetActive(true);
        }
    }
}
