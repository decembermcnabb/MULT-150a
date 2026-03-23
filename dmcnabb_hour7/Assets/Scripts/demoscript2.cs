using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demoscript2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int health = 20;

        if (health == 0) // == equal, != unequal
        {
            Debug.Log("player has been unalived"); 
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
