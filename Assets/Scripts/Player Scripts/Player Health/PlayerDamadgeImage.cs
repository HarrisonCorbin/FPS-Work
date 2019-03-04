using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerDamadgeImage : MonoBehaviour
{

    public GameObject Player;
    public GameObject Ground;
    public int currenthealth = 100;
    public Image Image;
    public Slider healthSlider;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthSlider.value = currenthealth;
        var tempColor = Image.color;
        tempColor.a = 0f;
        Image.color = tempColor;

        int Groundlev = Mathf.RoundToInt(Ground.transform.position.y);
        int myY = Mathf.RoundToInt(Player.transform.position.y);


        if (myY == Groundlev)
        {
            tempColor.a = 1f;
            Image.color = tempColor;

            currenthealth = currenthealth - 10;
            healthSlider.value = currenthealth;
        }
    }

    

}
