using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiraCamera : MonoBehaviour {

    float posx;
    float posy;
    float posz;
    float angx;
    float angy;
    float angz;

	// Use this for initialization
	void Start () {
        posx = transform.position.x;
        posz = transform.position.z;
        posy = transform.position.y;

        angx = transform.eulerAngles.x;
        angy = transform.eulerAngles.y;
        angz = transform.eulerAngles.z;
	}
	
	// Update is called once per frame
	void Update () {
        //normal
		if(Sistema.Casaatual > 42 || Sistema.Casaatual < 7)
        {
            transform.position = new Vector3(
                    posx = 0,
                    posy = 175,
                    posz = 180
                    
                );
            transform.eulerAngles = new Vector3(
                    posx = 135,
                    posy = 0,
                    posz = 180

                );
        }
        //direita
        if (Sistema.Casaatual >= 7 && Sistema.Casaatual < 17)
        {
            transform.position = new Vector3(
                    posx = -130,
                    posy = 215,
                    posz = 0

                );
            transform.eulerAngles = new Vector3(
                    posx = 59.4f,
                    posy = 90,
                    posz = 0

                );
        }
        //fundo
        if (Sistema.Casaatual >= 17 && Sistema.Casaatual < 32)
        {
            transform.position = new Vector3(
                    posx = 0,
                    posy = 175,
                    posz = -180

                );
            transform.eulerAngles = new Vector3(
                    posx = 45,
                    posy = 0,
                    posz = 0

                );
        }
        //esquerda
        if (Sistema.Casaatual >= 32 && Sistema.Casaatual < 42)
        {
            transform.position = new Vector3(
                    posx = 135,
                    posy = 212,
                    posz = 0

                );
            transform.eulerAngles = new Vector3(
                    posx = 122,
                    posy = 90,
                    posz = 180

                );
        }
    }
}
