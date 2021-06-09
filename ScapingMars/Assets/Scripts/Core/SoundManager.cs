using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instace { get; private set; }

    private AudioSource source;
    private void Awake()
    {
        instace = this;
        source = GetComponent<AudioSource>();
    }

    public void PlaySound(AudioClip sound)
    {
        source.PlayOneShot(sound);
    }
    
    
    
}
