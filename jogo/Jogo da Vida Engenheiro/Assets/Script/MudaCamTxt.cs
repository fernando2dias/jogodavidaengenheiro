using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MudaCamTxt : MonoBehaviour {

    public Camera c1, c2;
    public GameObject btnVerCarta, btnVoltaPrincipal;
    public static bool mostraCartas, mostraBtnEscolha;

	// Use this for initialization
	void Start () {
        c1.gameObject.SetActive(true);
        c2.gameObject.SetActive(false);
        btnVerCarta.SetActive(false);
        mostraCartas = false;
        mostraBtnEscolha = false;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        // Habilita e desabilita o botão de escolher carta
        if (mostraBtnEscolha)
        {
            btnVerCarta.SetActive(true);
        }
        mostraBtnEscolha = false;
    }

    // Função para ir para a tela da carta, quando apertar o botão "escolha uma carta"
    public void VerCarta()
    {
        c1.gameObject.SetActive(false);
        c2.gameObject.SetActive(true);
        mostraCartas = true;
        DiceScript.jogaDado = false;
    }

    //Função para voltar para a tela principal quando aperta no botão "voltar" da tela da carta
    public void VoltaTelaPrincipal()
    {
        c1.gameObject.SetActive(true);
        c2.gameObject.SetActive(false);
        btnVerCarta.SetActive(false);

        DiceScript.jogaDado = true;
    }
}
