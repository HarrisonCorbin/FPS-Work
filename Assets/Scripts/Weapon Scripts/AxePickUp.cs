﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxePickUp : MonoBehaviour
{
    public GameObject playerCamera;
    public GameObject playerHands;
    public GameObject Axe;
    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {


    }

    void OnTriggerStay(Collider other)
    {
        //The pick up key
        if (Input.GetKeyDown(KeyCode.F))
        {

            if (GetComponent<Collider>().gameObject.name == "Axe")
            {
           
                Axe.transform.parent = playerHands.gameObject.transform;
                Axe.transform.localPosition = new Vector3(2, 1, 1);
                Axe.transform.localRotation = Quaternion.identity;
                Axe.GetComponent<Rigidbody>().isKinematic = true;
                Axe.GetComponent<Collider>().enabled = true;


            }
        }
    }
}
