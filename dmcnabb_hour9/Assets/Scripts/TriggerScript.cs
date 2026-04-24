using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered " + gameObject.name);
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Exited " + gameObject.name);
    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log("Staying in " + gameObject.name);
    }
}
