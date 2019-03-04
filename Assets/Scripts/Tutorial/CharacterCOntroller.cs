using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCOntroller : MonoBehaviour {

    public float speed = 10.0f;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update () {
        float forwardBack = Input.GetAxis("Vertical") * speed;
        float leftRight = Input.GetAxis("Horizontal") * speed;
        forwardBack *= Time.deltaTime;
        leftRight *= Time.deltaTime;

        transform.Translate(forwardBack, 0, leftRight);
	}
}
