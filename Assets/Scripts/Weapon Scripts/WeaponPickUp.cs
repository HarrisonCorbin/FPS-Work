﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickUp : MonoBehaviour
{
    public GameObject playerCamera;
    public GameObject playerHands;
    public GameObject Weapon;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<Collider>().gameObject.name == "Weapon")
        {
            //The pick up key
            if (Input.GetKeyDown(KeyCode.F))
            {
                Weapon.transform.parent = playerHands.gameObject.transform;
                Weapon.transform.localPosition = new Vector3(2, 1, 1);
                Weapon.transform.localRotation = Quaternion.identity;
                Weapon.GetComponent<Rigidbody>().isKinematic = true;
                Weapon.GetComponent<Collider>().enabled = true;
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {

        if (GetComponent<Collider>().gameObject.name == "Weapon")
        {
            //The pick up key
            if (Input.GetKeyDown(KeyCode.F))
            {
                Weapon.transform.parent = playerHands.gameObject.transform;
                Weapon.transform.localPosition = new Vector3(2, 1, 1);
                Weapon.transform.localRotation = Quaternion.identity;
                Weapon.GetComponent<Rigidbody>().isKinematic = true;
                Weapon.GetComponent<Collider>().enabled = true;
            }
        }
        
    }
}

