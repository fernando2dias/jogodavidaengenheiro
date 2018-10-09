using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameras : MonoBehaviour {

    public Camera[] cameras;
    public int numeroCameras;
    public int NumeroMaxCam;

	// Use this for initialization
	void Start () {
        NumeroMaxCam = cameras.Length;
        numeroCameras = 1;
        foreach(Camera obj in cameras)
        {
            obj.gameObject.SetActive(false);
        }
        cameras[numeroCameras - 1].gameObject.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.RightArrow) && numeroCameras < NumeroMaxCam)
        {
            numeroCameras++;
            foreach(Camera obj in cameras)
            {
                obj.gameObject.SetActive(false);
            }
            cameras[numeroCameras - 1].gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && numeroCameras == NumeroMaxCam)
        {
            foreach (Camera obj in cameras)
            {
                obj.gameObject.SetActive(false);
            }
            cameras[numeroCameras - 1].gameObject.SetActive(true);
            numeroCameras = 0;
        }
    }
}
