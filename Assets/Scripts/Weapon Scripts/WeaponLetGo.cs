using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponLetGo : MonoBehaviour
{
    public GameObject playerCamera;
    public GameObject Weapon;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
                if (Input.GetKeyDown(KeyCode.G))
                {
                    Weapon.transform.parent = null;
                    Weapon.GetComponent<Rigidbody>().isKinematic = false;
                    Weapon.GetComponent<Collider>().enabled = true;
        }

            
        
    }
}
