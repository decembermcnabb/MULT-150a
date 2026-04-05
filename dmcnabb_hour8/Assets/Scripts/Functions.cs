using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    void Start()
    {
        // string sentence = "W in the chat";
        // LogSomething(sentence);

        // string sentence2 = "L in the chat";
        // LogSomething(sentence2);

        LogSomething("I'm a hard coded string");

        LogSomething("W coding!", 100);
    }

    void Update()
    {
        // Empty for now—fine
    }

    void LogSomething(string something, int numLoops)
    {
        for (int i = 1; i <= numLoops; i++)
        {
            Debug.Log(something);
        }
    }

    void LogSomething(string something)
    {
        for (int i = 1; i <= 3; i++)
        {
            Debug.Log(something);
        }
    }
}