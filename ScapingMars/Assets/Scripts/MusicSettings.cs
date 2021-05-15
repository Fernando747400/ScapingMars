using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSettings : MonoBehaviour
{
    private AudioSource audioSource;
    private int volumeOff = 0;
    private int volumeOn = 1;
    private int volume;
    private bool val = true;
    


    void Update()
    {
        volume = PlayerPrefs.GetInt("Music");
        

        if (PlayerPrefs.GetInt("Music") == 0)
        {
            PlayerPrefs.Save();
        }

        if (PlayerPrefs.GetInt("Music") == 1)
        {
            PlayerPrefs.Save();
        }
        
    }
    public void SetVolumeOn()
    {
        ///audioSource.volume = volumeOn;
        //volume = 1;
    }
    
    public void SetVolumOff()
    {
       //audioSource.volume = volumeOff;
       // volume = 0;
    }
    

}
