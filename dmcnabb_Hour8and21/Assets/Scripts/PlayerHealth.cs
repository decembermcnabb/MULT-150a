using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    int healthpoints = 3992;   // placed above Start() exactly like runSpeed in Hour 7

    // Start is called before the first frame update
    void Start()
    {
        //Start of potion use until health is 5592
        healthpoints = UsePotion(healthpoints);
        Debug.Log(healthpoints);

        healthpoints = UsePotion(healthpoints);
        Debug.Log(healthpoints);

        healthpoints = UsePotion(healthpoints);
        Debug.Log(healthpoints);

        healthpoints = UsePotion(healthpoints);
        Debug.Log(healthpoints);
    }

    // Update is called once per frame
    void Update()
    {

    }

    // NEW METHOD — placed BELOW the Update() block
    int UsePotion(int health)
    {
        health += 400;
        return health;
    }
}