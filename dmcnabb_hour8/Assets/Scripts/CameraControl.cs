using UnityEngine;

public class CameraControl : MonoBehaviour
{
    //Camera movment speed
    public float speed = 2f;

    void Update()
    {
        //Mouse movement for vertical and horizontal directions(u,d,l,r)
        float x = Input.GetAxis("Mouse X");
        float y = Input.GetAxis("Mouse Y");

        //Camera movement axes
        transform.Translate(x * speed, y * speed, 0);
    }
}