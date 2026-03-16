using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float health; 
        float poisondamage;
        health = 1004f;
        poisondamage = 125.5f;
        Debug.Log(health);

        health -= poisondamage;
        Debug.Log(health);

        health -= poisondamage;
        Debug.Log(health);

        health -= poisondamage;
        Debug.Log(health);

        health -= poisondamage;
        Debug.Log(health);

        health -= poisondamage;
        Debug.Log(health);

        health -= poisondamage;
        Debug.Log(health);

        health -= poisondamage;
        Debug.Log(health);

        health -= poisondamage;
        Debug.Log(health);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
