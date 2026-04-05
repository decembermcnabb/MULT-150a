using UnityEngine;

public class LightScript : MonoBehaviour
{
    //Reference for light object stuff
    Light bulbLight;

    void Start()
    {
        //Start scene with Light component
        bulbLight = GetComponent<Light>();
    }

    void Update()
    {
        //Input for L for light stuff
        if (Input.GetKeyDown(KeyCode.L))
        {
            //If and else for turning on light or off
            if (bulbLight.enabled == true)
            {
                bulbLight.enabled = false;
            }
            else
            {
                bulbLight.enabled = true;
            }
        }
    }
}