using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demoscript2_forloops : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Count 7 days of a week 
        for (int d = 1; d <= 7; d++)
        {
            Debug.Log(d);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
