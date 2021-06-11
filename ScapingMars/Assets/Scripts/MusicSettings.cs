using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicSettings : MonoBehaviour
{

    [Header("AduioBoton")]
    [SerializeField] GameObject boton;
    Image image;

    [SerializeField] Sprite spriteSound;
    Sprite firstSprite;
    


    private AudioSource audioSource;

    public void Start()
    {
        image = boton.GetComponent<Image>();
       
        firstSprite = image.sprite;
        


        audioSource = this.GetComponent<AudioSource>();
        if (!PlayerPrefs.HasKey("Music"))
        {
            PlayerPrefs.SetInt("Music", 1);
        }
    }

    public void muteAudio()
    {
        

        if (PlayerPrefs.GetInt("Music") == 0)
        {
            PlayerPrefs.SetInt("Music", 1);

            image.sprite = firstSprite;
            
        }
        else if (PlayerPrefs.GetInt("Music") == 1)
        {
            PlayerPrefs.SetInt("Music", 0);
            image.sprite = spriteSound;

            
            
        }

        audioSource.volume = PlayerPrefs.GetInt("Music");
    }

    

}
