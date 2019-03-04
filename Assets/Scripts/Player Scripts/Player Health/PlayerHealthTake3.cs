using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerHealthTake3 : MonoBehaviour {

    public GameObject Player;
    public GameObject Enemy;
    public int currenthealth;
    public Slider healthSlider;
    // Use this for initialization
    void Start ()
    {

    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Enemy")
        {
            currenthealth = currenthealth - 5;
        }
    }


    // Update is called once per frame
    void Update ()
    {
        healthSlider.value = currenthealth;

        if(currenthealth < 0)
        {
            currenthealth = 100;
        }
    }
}
