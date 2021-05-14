using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSettings : MonoBehaviour
{
    private AudioSource audioSource;
    private int volume;
    void Start()
    {
        volume = PlayerPrefs.GetInt("Music");
    }

    public void setVolume()
    {
        audioSource.volume = volume;
    }

}
