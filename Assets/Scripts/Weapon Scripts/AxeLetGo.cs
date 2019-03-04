using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeLetGo : MonoBehaviour {

    public GameObject playerCamera;
    public GameObject Axe;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            Axe.transform.parent = null;
            Axe.GetComponent<Rigidbody>().isKinematic = false;
            Axe.GetComponent<Collider>().enabled = true;
        }

    }
}
