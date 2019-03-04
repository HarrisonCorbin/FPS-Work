using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerDamage : MonoBehaviour {

    public GameObject Player;
    public GameObject Ground;
    public int currenthealth = 100;
    public Image damageImage;
    public Slider healthSlider;
    public float flashSpeed = 5f;
    bool isDamadged = false;
    bool isDead = false;
    
    
    // Use this for initialization
    void Start() {


    }

    // Update is called once per frame
    void Update()
    {

        int Groundlev = Mathf.RoundToInt(Ground.transform.position.y);
        int myY = Mathf.RoundToInt(Player.transform.position.y);
        
       

        if (myY == Groundlev)
        {
            isDamadged = true;
           

            if (isDamadged)
            {
                var flashColour = damageImage.color;
                flashColour.a = 1f;
                damageImage.color = flashColour;
            }
            
        }   
    }

    

    public void takeDamage()
    {
 
       currenthealth = currenthealth - 50;

        healthSlider.value = currenthealth;

        if (currenthealth <= 0 && !isDead)
        {
            Death();
        }
    }

    void Death()
    {
        isDead = true;
    }

}
