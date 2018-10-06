using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Sistema : MonoBehaviour {

    public Transform[] Casas;
    int Casaatual = 0;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Casaatual = Casaatual + DiceNumberTextScript.diceNumber;
            if (Casaatual < Casas.Length)
            {
                transform.position = Casas[Casaatual].position;
                Debug.Log(Casaatual);
            }
            else
            {
                Casaatual = 46;
                transform.position = Casas[Casaatual].position;
            }
        }
    }

}
