﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    public GameObject Enemy;
    public int currenthealth;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Sword")
        {
            currenthealth = currenthealth - 5;
        }

        if (currenthealth < 0)
        {
            Enemy.GetComponent<Rigidbody>().isKinematic = true;
        }
    }
}
