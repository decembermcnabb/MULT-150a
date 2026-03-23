using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demoscript2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int health = 100;

        if (health == 0) // == equal, != not equal
        {
            Debug.Log("player has been unalived");
        }
        else if (health < 30)
        {
            Debug.Log("DANGER! Low health.");
        }
        else if (health == 100)
        {
            Debug.Log("Player is chilling");
        }
        else
        {
            Debug.Log("player is alive");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
