using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceScript : MonoBehaviour {

	static Rigidbody rb;
	public static Vector3 diceVelocity;
    public static bool jogaDado;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
        jogaDado = true;
	}
	
	// Update is called once per frame
	void Update () {
		diceVelocity = rb.velocity;

        if (Input.GetKeyDown(KeyCode.Space) && jogaDado)
        {
            float dirX = Random.Range(0, 1000);
            float dirY = Random.Range(0, 1000);
            float dirZ = Random.Range(0, 1000);
            transform.position = new Vector3(-1, 20, -3);
            transform.rotation = Quaternion.identity;
            rb.AddForce(transform.up * 1000);
            rb.AddTorque(dirX, dirY, dirZ);

            Sistema.dadoParado = false;
            jogaDado = false;
            SorteiaCarta.mudaCarta = true;

            MudaCamTxt.mostraBtnEscolha = true;
        }       
	}
}
