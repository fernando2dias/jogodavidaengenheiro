using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPrincipal : MonoBehaviour {

    float posz;
    float posy;
    float posx;
    float angx;
    float angz;
    float angy;
    //bool mudou = false;

	// Use this for initialization
	void Start () {
        posz = transform.position.z;
        posy = transform.position.y;
        posx = transform.position.x;
        angx = transform.eulerAngles.x;
        angz = transform.eulerAngles.z;
        angy = transform.eulerAngles.y;
    }

    void Update()
    {
        //posicao padrão 0.1, 175, 179
        // posição final 0.1, 175, -179
        transform.position = new Vector3(
                posx,
                posy,
                posz
            );
        // final 135, 180, -180
        // inicial 45, 180, 0
        transform.eulerAngles = new Vector3(
                angx,
                angy,
                angz
            );
        //position -180, 175, 0
        //rotation 135, 270, 180
        if ((Sistema.Casaatual > 7 && Sistema.Casaatual < 18))
        {
            posx = -180;
            posy = 175;
            posz = 0;
            angx = 135;
            angy = 270;
            angz = 180;
        }
        if ((Sistema.Casaatual >= 18 && Sistema.Casaatual <= 30))
        {
            posx = 0;
            posy = 175;
            posz = -180;
            angx = 45;
            angy = 0;
            angz = 0;
        }
        //position 180, 175, 0
        //rotation 45, 270, 0
        if ((Sistema.Casaatual > 30 && Sistema.Casaatual <= 41))
        {
            posx = 180;
            posy = 175;
            posz = 0;
            angx = 45;
            angy = 270;
            angz = 0;
        }
        if ((Sistema.Casaatual < 7 || Sistema.Casaatual > 42))
        {
            posx = 0;
            posy = 175;
            posz = 180;
            angx = 135;
            angy = 0;
            angz = 180;
        }
    }
}
