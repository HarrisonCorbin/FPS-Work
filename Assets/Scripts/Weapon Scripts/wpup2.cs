using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wpup2 : MonoBehaviour
{

    public GameObject Weapon;
    public GameObject playerHands;
    public GameObject playerCamera;

    public bool exit = true;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        

       
    }



    void OnTriggerEnter(Collider other)
    {
   
            if (Input.GetKeyDown(KeyCode.F))
            {
                Weapon.transform.parent = playerHands.gameObject.transform;
                Weapon.transform.localPosition = new Vector3(2, 1, 1);
                Weapon.transform.localRotation = Quaternion.identity;
                Weapon.GetComponent<Rigidbody>().isKinematic = true;
                Weapon.GetComponent<Collider>().enabled = false;
            }
        
    }
}
