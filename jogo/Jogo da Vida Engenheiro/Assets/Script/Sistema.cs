using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Sistema : MonoBehaviour
{

    public Transform[] Casas;
    public static int Casaatual = 0;
    public static bool dadoParado = false;


    public static void Anda(int Nova)
    {
        if (dadoParado == false)
        {
            Casaatual = Casaatual + Nova;
            dadoParado = true;
            
        }
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

       // Casaatual = Casaatual + DiceNumberTextScript.diceNumber;

        if (Casaatual < Casas.Length)
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
