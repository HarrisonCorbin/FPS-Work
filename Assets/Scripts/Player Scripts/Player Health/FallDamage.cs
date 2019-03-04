using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class FallDamage : MonoBehaviour
{

    //time player can spend in the air without damage
    public float minSurviveFall;
    //damage taken for every second in the air
    public float damageForSeconds;

    //player Health variables
    public Slider healthSlider;
    public float currentHealth;

    //how long you've been in the air for
    public float airTime = 0;

    //variables to calculate the position of the Ground and if it's touching the player
    public bool ready = false;

    void Start()
    {

    }


    void Update()
    {

        //setting the health variable to the health bar slider
        healthSlider.value = currentHealth;

        //if health is below 0, reset the health bar
        if (currentHealth < 0)
        {
            currentHealth = 100;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ready = true;
        }

        if (ready == true)
        {

            //When Space is pressed, it should start counting down
            airTime += Time.deltaTime;
        }

        if (ready == false)
        {

            //deals the damage when the player hits the gorund   
            if (airTime > minSurviveFall)
            {
                //calculate the fall damage to subtract
                currentHealth = currentHealth - (damageForSeconds * airTime);
                
                //resets the falling timer
                airTime = 0;
            }


            //If the fall time is less than the damage time the timer will still reset
            if (airTime < minSurviveFall)
            {
                airTime = 0;
            }

        }

        
    }

    //If the player hits the ground or a lower surface it'll trigger the damaging function of false
    void OnTriggerStay(Collider other)
    {
        ready = false;
    }
}   