using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnemyHealthTracker : MonoBehaviour {
    public GameObject Enemy;
    public Slider healthSlider;


    // Use this for initialization
    void Start () {

        
          
    }

// Update is called once per frame
void Update () {


        var wantedPos = Enemy.transform.position;
        transform.position = wantedPos;

    }
}
