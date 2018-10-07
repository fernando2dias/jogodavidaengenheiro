using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Sistema : MonoBehaviour {

    public Transform[] Casas;
    public static int Casaatual = 0;
    int numDado;
    int num = 0;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        numDado = DiceNumberTextScript.diceNumber;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Casaatual = Casaatual + numDado;
            if ((Casaatual < Casas.Length))
            {
                transform.position = Casas[Casaatual].position;
            }
            else
            {
                Casaatual = 46;
                transform.position = Casas[Casaatual].position;
            }
        }
    }

}
