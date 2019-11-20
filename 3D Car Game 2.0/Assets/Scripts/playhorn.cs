using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playhorn : MonoBehaviour
{

    AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void beep()
    {
        audio.Play();
    }
}
