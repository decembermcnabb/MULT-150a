using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        ToggleAudio();   //Cleaned up from the GetKey Z stuff
    }

    void ToggleAudio()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            AudioSource audio = GetComponent<AudioSource>();
            if (audio.isPlaying)
            {
                audio.Stop();
            }
            else
            {
                audio.Play();
            }
        }
    }
}
