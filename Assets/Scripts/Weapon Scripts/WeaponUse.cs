using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponUse : MonoBehaviour
{
    public GameObject playerCamera;
    public GameObject Weapon;
    public GameObject playerHands;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(Help());
    }

    // Update is called once per frame
    void Update()
    {
        if (Weapon.transform.parent == playerHands.gameObject.transform)
        {

            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                var rotationVector = transform.rotation.eulerAngles;
                rotationVector.z = -45;
                Weapon.transform.rotation = Quaternion.Euler(rotationVector);
            }

        }
    }

    //failed attempt at pausing before returning to 0 degrees

    IEnumerator Help()
    {
        if (Weapon.transform.parent == playerHands.gameObject.transform)
        {

            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                var rotationVector = transform.rotation.eulerAngles;
                rotationVector.z = -45;
                Weapon.transform.rotation = Quaternion.Euler(rotationVector);

                yield return new WaitForSeconds(2);

                rotationVector.z = 0;
                Weapon.transform.rotation = Quaternion.Euler(rotationVector);
            }

        }
    }
    
      
    

}