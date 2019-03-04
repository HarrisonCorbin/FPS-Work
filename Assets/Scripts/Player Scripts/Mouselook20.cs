using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouselook20 : MonoBehaviour {

    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        yaw += speedH * Input.GetAxis("Mouse X");
        pitch += speedV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(0.0f, yaw, pitch);
 

        if (pitch > 45.0f)
        {
            pitch = 45.0f;
        }

        if (pitch < -45.0f)
        {
            pitch = -45.0f;
        }
    }
}
