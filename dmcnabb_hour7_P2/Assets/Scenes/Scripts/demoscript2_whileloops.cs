using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demoscript2_whileloops : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // get sum of all numbers from 1 to 10
        int sum = 0;
        int count = 1; 
        while (count <= 10)
        {
            Debug.Log("sum:" + sum + " count:" + count);
            sum = sum + count; // sum += count
            count++;
        }
        Debug.Log("final sum: " + sum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
