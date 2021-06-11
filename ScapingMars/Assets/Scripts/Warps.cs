using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warps : MonoBehaviour
{

    public GameObject target;

    private bool start = false;
    private bool isFadeIn = false;
    float aplha = 0;
    private float FadeTime = 1f;
    


    private void Awake()
    {
        //Se vuelve insivible 
        GetComponent<SpriteRenderer>().enabled = false;
        transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = false;
    }


    IEnumerator OnTriggerEnter2D(Collider2D other)
    {
       // Debug.Log("PlayerToca Warp");
        other.GetComponent<Animator>().enabled = false;
        other.GetComponent<Player>().enabled = false;
        FadeIn();
        yield return new WaitForSeconds(FadeTime);
        
       if (other.CompareTag("Player"))
       {    
           //Debug.Log("Player se teletransporta al warp");
           other.transform.position = target.transform.GetChild(0).transform.position;
       }
       FadeOut();
       other.GetComponent<Animator>().enabled = true;
       other.GetComponent<Player>().enabled = true;
    }

    void OnGUI()
    {
        if (!start)
            return;
        GUI.color = new Color (GUI.color.r, GUI.color.g, GUI.color.b, aplha);
        
        Texture2D tex;
        tex = new Texture2D(1, 1);
        tex.SetPixel(0,0, Color.black);
        tex.Apply();
        
        GUI.DrawTexture(new Rect(0,0, Screen.width, Screen.height),tex);

        if (isFadeIn)
        {
            aplha = Mathf.Lerp(aplha, 1.1f, FadeTime * Time.deltaTime);
        }
        else
        { 
            aplha = Mathf.Lerp(aplha, -0.1f, FadeTime * Time.deltaTime);
            if (aplha < 0)
            {
                start = false;
            }
        }
    }

   public void FadeIn()
    {
        start = true;
        isFadeIn = true;
    }

   public void FadeOut()
    {
        isFadeIn = false;
    }
}


    
    
    
    
    

